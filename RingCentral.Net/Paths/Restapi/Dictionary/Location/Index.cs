using System.Threading.Tasks;
using System.Threading;

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

        /// <summary>
        /// Operation: Get Location List
        /// Http Get /restapi/v1.0/dictionary/location
        /// </summary>
        public async Task<RingCentral.GetLocationListResponse> Get(ListLocationsParameters queryParams = null,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Get<RingCentral.GetLocationListResponse>(this.Path(), queryParams, cancellationToken);
        }
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