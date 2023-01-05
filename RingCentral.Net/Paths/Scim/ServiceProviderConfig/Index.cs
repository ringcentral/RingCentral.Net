using System.Threading.Tasks;

namespace RingCentral.Paths.Scim.ServiceProviderConfig
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
            return $"{parent.Path()}/ServiceProviderConfig";
        }

        /// <summary>
        ///     Returns SCIM service provider configuration
        ///     HTTP Method: get
        ///     Endpoint: /scim/{version}/ServiceProviderConfig
        ///     Rate Limit Group: Light
        ///     App Permission: ReadAccounts
        /// </summary>
        public async Task<ScimProviderConfig> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<ScimProviderConfig>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Scim
{
    public partial class Index
    {
        public ServiceProviderConfig.Index ServiceProviderConfig()
        {
            return new ServiceProviderConfig.Index(this);
        }
    }
}