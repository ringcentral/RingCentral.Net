using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.ActiveCalls
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Index parent;

        public Index(Restapi.Account.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/active-calls";
        }

        public async Task<RingCentral.ActiveCallsResponse> Get(GetQueryParams queryParams = null)
        {
            return await rc.Get<RingCentral.ActiveCallsResponse>(this.Path(), queryParams);
        }

        public async Task<RingCentral.ActiveCallsResponse> Get(object queryParams)
        {
            return await rc.Get<RingCentral.ActiveCallsResponse>(this.Path(), queryParams);
        }
    }

    public class GetQueryParams
    {
        // The direction for the result records. If not specified, both inbound and outbound records are returned. Multiple values are accepted
        public string[] direction;

        // View of call records. The same view parameter specified for FSync will be applied for ISync, the view cannot be changed for ISync
        // Enum: Simple, Detailed
        public string view;

        // Call type of a record. If not specified, all call types are returned. Multiple values are accepted
        public string[] type;

        // Call transport type. 'PSTN' specifies that a call leg is initiated from the PSTN network provider; 'VoIP' - from an RC phone. By default this filter is disabled
        public string[] transport;

        // Indicates the page number to retrieve. Only positive number values are accepted
        public long? page;

        // Indicates the page size (number of items)
        public long? perPage;
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public Restapi.Account.ActiveCalls.Index ActiveCalls()
        {
            return new Restapi.Account.ActiveCalls.Index(this);
        }
    }
}