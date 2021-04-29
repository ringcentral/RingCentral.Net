using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.MessageStoreConfiguration
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Index parent;

        public Index(Restapi.Account.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/message-store-configuration";
        }

        /// <summary>
        /// Returns message store settings.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/message-store-configuration
        /// Rate Limit Group: Light
        /// App Permission: EditAccounts
        /// User Permission: AccountAdministration
        /// </summary>
        public async Task<RingCentral.MessageStoreConfiguration> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.MessageStoreConfiguration>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Updates message store settings.
        /// HTTP Method: put
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/message-store-configuration
        /// Rate Limit Group: Light
        /// App Permission: EditAccounts
        /// User Permission: AccountAdministration
        /// </summary>
        public async Task<RingCentral.MessageStoreConfiguration> Put(
            RingCentral.MessageStoreConfiguration messageStoreConfiguration, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Put<RingCentral.MessageStoreConfiguration>(this.Path(), messageStoreConfiguration, null,
                restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public Restapi.Account.MessageStoreConfiguration.Index MessageStoreConfiguration()
        {
            return new Restapi.Account.MessageStoreConfiguration.Index(this);
        }
    }
}