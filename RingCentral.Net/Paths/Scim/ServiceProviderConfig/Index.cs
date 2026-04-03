using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

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
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/ServiceProviderConfig";
        }
        /// <summary>
        /// Returns SCIM service provider configuration
        /// HTTP Method: get
        /// Endpoint: /scim/{version}/ServiceProviderConfig
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// </summary>
        public async Task<RingCentral.ScimProviderConfig> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.ScimProviderConfig>(this.Path(), null, restRequestConfig);
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