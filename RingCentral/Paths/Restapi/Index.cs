using System.Threading.Tasks;

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

        public string Path()
        {
            if (apiVersion != null)
            {
                return $"/restapi/{apiVersion}";
            }

            return "/restapi";
        }

        public async Task<GetVersionsResponse> List()
        {
            return await rc.Get<GetVersionsResponse>(this.Path());
        }

        public async Task<GetVersionResponse> Get()
        {
            return await rc.Get<GetVersionResponse>(this.Path());
        }
    }
}