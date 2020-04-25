using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Scim.Health
{
    public partial class Index
    {
        public RestClient rc;
        public Scim.Index parent;

        public Index(Scim.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/health";
        }

        /// <summary>
        /// Operation: Check Health
        /// HTTP Method: GET
        /// Endpoint: /scim/v2/health
        /// Rate Limit Group: NoThrottling
        /// App Permission: undefined
        /// User Permission: undefined
        /// </summary>
        public async Task<string> Get(CancellationToken? cancellationToken = null)
        {
            return await rc.Get<string>(this.Path(), null, cancellationToken);
        }
    }
}

namespace RingCentral.Paths.Scim
{
    public partial class Index
    {
        public Scim.Health.Index Health()
        {
            return new Scim.Health.Index(this);
        }
    }
}