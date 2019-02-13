using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.ActiveCalls
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Extension.Index parent;

        public Index(Restapi.Account.Extension.Index parent)
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

        // Indicates the page number to retrieve. Only positive number values are allowed
        public long? page;

        // Indicates the page size (number of items)
        public long? perPage;
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.ActiveCalls.Index ActiveCalls()
        {
            return new Restapi.Account.Extension.ActiveCalls.Index(this);
        }
    }
}