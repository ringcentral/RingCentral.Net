using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Dictionary.Location
{
    public class Index
    {
        public Dictionary.Index parent;
        public RestClient rc;

        public Index(Dictionary.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/location";
        }

        /// <summary>
        ///     Returns all available locations for a certain state.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/dictionary/location
        ///     Rate Limit Group: Light
        /// </summary>
        public async Task<GetLocationListResponse> Get(
            ListLocationsParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<GetLocationListResponse>(Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Dictionary
{
    public partial class Index
    {
        public Location.Index Location()
        {
            return new Location.Index(this);
        }
    }
}