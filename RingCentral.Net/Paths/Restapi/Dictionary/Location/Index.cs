using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

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
        /// Returns all available locations for a certain state.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/dictionary/location
        /// Rate Limit Group: Light
        /// </summary>
        public async Task<RingCentral.GetLocationListResponse> Get(
            RingCentral.ListLocationsParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.GetLocationListResponse>(this.Path(), queryParams, restRequestConfig);
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