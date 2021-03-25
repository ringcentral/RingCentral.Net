using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi
{
    public partial class Index
    {
        public RestClient rc;
        public string apiVersion;

        public Index(RestClient rc, string apiVersion = "v1.0")
        {
            this.rc = rc;
            this.apiVersion = apiVersion;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && apiVersion != null)
            {
                return $"/restapi/{apiVersion}";
            }

            return "/restapi";
        }

        /// <summary>
        /// Returns current API version(s) and server info.
        /// HTTP Method: GET
        /// Endpoint: /restapi
        /// Rate Limit Group: NoThrottling
        /// App Permission: 
        /// User Permission: undefined
        /// </summary>
        public async Task<RingCentral.GetVersionsResponse> List(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.GetVersionsResponse>(this.Path(false), null, restRequestConfig);
        }

        /// <summary>
        /// Returns current API version info by apiVersion.
        /// HTTP Method: GET
        /// Endpoint: /restapi/{apiVersion}
        /// Rate Limit Group: NoThrottling
        /// App Permission: 
        /// User Permission: undefined
        /// </summary>
        public async Task<RingCentral.GetVersionResponse> Get(RestRequestConfig restRequestConfig = null)
        {
            if (this.apiVersion == null)
            {
                throw new System.ArgumentNullException("apiVersion");
            }

            return await rc.Get<RingCentral.GetVersionResponse>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral
{
    public partial class RestClient
    {
        public Paths.Restapi.Index Restapi(string apiVersion = "v1.0")
        {
            return new Paths.Restapi.Index(this, apiVersion);
        }
    }
}