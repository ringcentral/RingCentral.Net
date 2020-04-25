using System.Threading.Tasks;
using System.Threading;

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
        /// Operation: Get API Versions
        /// Http Get /restapi
        /// </summary>
        public async Task<RingCentral.GetVersionsResponse> List(CancellationToken? cancellationToken = null)
        {
            return await rc.Get<RingCentral.GetVersionsResponse>(this.Path(false), null, cancellationToken);
        }

        /// <summary>
        /// Operation: Get Version Info
        /// Http Get /restapi/{apiVersion}
        /// </summary>
        public async Task<RingCentral.GetVersionResponse> Get(CancellationToken? cancellationToken = null)
        {
            if (this.apiVersion == null)
            {
                throw new System.ArgumentNullException("apiVersion");
            }

            return await rc.Get<RingCentral.GetVersionResponse>(this.Path(), null, cancellationToken);
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