using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi
{
    public class Index
    {
        public RestClient rc;
        public string apiVersion;

        public Index(RestClient rc, string apiVersion = "v1.0")
        {
            this.rc = rc;
            this.apiVersion = apiVersion;
        }

        public async Task<GetVersionsResponse> List()
        {
            return await rc.Get<GetVersionsResponse>("/restapi");
        }

        public async Task<GetVersionResponse> Get()
        {
            return await rc.Get<GetVersionResponse>($"/restapi/{apiVersion}");
        }
    }
}