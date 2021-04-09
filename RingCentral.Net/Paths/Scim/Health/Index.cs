using System.Threading.Tasks;

namespace RingCentral.Paths.Scim.Health
{
    public class Index
    {
        public Scim.Index parent;
        public RestClient rc;

        public Index(Scim.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/health";
        }

        /// <summary>
        ///     Check Health
        ///     HTTP Method: get
        ///     Endpoint: /scim/{version}/health
        ///     Rate Limit Group: NoThrottling
        /// </summary>
        public async Task<string> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<string>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Scim
{
    public partial class Index
    {
        public Health.Index Health()
        {
            return new Health.Index(this);
        }
    }
}