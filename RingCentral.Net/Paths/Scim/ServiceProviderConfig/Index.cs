using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Scim.ServiceProviderConfig
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
            return $"{parent.Path()}/ServiceProviderConfig";
        }

        /// <summary>
        /// Operation: Get Service Provider Config
        /// HTTP Method: GET
        /// Endpoint: /scim/v2/ServiceProviderConfig
        /// Rate Limit Group: NoThrottling
        /// App Permission: undefined
        /// User Permission: undefined
        /// </summary>
        public async Task<RingCentral.ServiceProviderConfig> Get(CancellationToken? cancellationToken = null)
        {
            return await rc.Get<RingCentral.ServiceProviderConfig>(this.Path(), null, cancellationToken);
        }
    }
}

namespace RingCentral.Paths.Scim
{
    public partial class Index
    {
        public Scim.ServiceProviderConfig.Index ServiceProviderConfig()
        {
            return new Scim.ServiceProviderConfig.Index(this);
        }
    }
}