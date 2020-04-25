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
        /// Rate Limit Group: NoThrottling
        /// Http Get /scim/v2/health
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