using System.Threading.Tasks;

namespace RingCentral.Paths
{
    public class Restapi
    {
        public RestClient rc;
        public string apiVersion;

        public Restapi(RestClient rc, string apiVersion = "v1.0")
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