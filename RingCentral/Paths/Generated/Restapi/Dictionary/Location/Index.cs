using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Dictionary.Location
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Dictionary.Index parent;

        public Index(Restapi.Dictionary.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/location";
        }

        public async Task<RingCentral.GetLocationListResponse> Get(GetQueryParams queryParams = null)
        {
            return await rc.Get<RingCentral.GetLocationListResponse>(this.Path(), queryParams);
        }

        public async Task<RingCentral.GetLocationListResponse> Get(object queryParams)
        {
            return await rc.Get<RingCentral.GetLocationListResponse>(this.Path(), queryParams);
        }
    }

    public class GetQueryParams
    {
        // Sorts results by the property specified
        public string[] orderBy;

        // Indicates the page number to retrieve. Only positive number values are accepted
        public long? page;

        // Indicates the page size (number of items)
        public long? perPage;

        // Internal identifier of a state
        public string stateId;

        // Specifies if nxx codes are returned
        public bool? withNxx;
    }
}

namespace RingCentral.Paths.Restapi.Dictionary
{
    public partial class Index
    {
        public Restapi.Dictionary.Location.Index Location()
        {
            return new Restapi.Dictionary.Location.Index(this);
        }
    }
}