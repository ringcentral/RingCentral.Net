using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.MessageStoreConfiguration
{
    public class Index
    {
        public Account.Index parent;
        public RestClient rc;

        public Index(Account.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/message-store-configuration";
        }

        /// <summary>
        ///     Returns message store settings.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/message-store-configuration
        ///     Rate Limit Group: Light
        ///     App Permission: EditAccounts
        ///     User Permission: AccountAdministration
        /// </summary>
        public async Task<RingCentral.MessageStoreConfiguration> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.MessageStoreConfiguration>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Updates message store settings.
        ///     HTTP Method: put
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/message-store-configuration
        ///     Rate Limit Group: Light
        ///     App Permission: EditAccounts
        ///     User Permission: AccountAdministration
        /// </summary>
        public async Task<RingCentral.MessageStoreConfiguration> Put(
            RingCentral.MessageStoreConfiguration messageStoreConfiguration, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Put<RingCentral.MessageStoreConfiguration>(Path(), messageStoreConfiguration, null,
                restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public MessageStoreConfiguration.Index MessageStoreConfiguration()
        {
            return new MessageStoreConfiguration.Index(this);
        }
    }
}