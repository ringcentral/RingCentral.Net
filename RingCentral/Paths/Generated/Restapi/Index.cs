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

        public async Task<RingCentral.GetVersionsResponse> List()
        {
            return await rc.Get<RingCentral.GetVersionsResponse>(this.Path(false));
        }

        public async Task<RingCentral.GetVersionResponse> Get()
        {
            if (this.apiVersion == null)
            {
                throw new System.ArgumentNullException("apiVersion");
            }
        
            return await rc.Get<RingCentral.GetVersionResponse>(this.Path());
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