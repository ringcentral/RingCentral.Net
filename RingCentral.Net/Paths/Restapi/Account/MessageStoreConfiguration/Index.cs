using System.Threading.Tasks;
using System.Threading;

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
        /// Operation: Get Message Store Configuration
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/message-store-configuration
        /// Rate Limit Group: Light
        /// App Permission: EditAccounts
        /// User Permission: AccountAdministration
        /// </summary>
        public async Task<RingCentral.MessageStoreConfiguration> Get(CancellationToken? cancellationToken = null)
        {
            return await rc.Get<RingCentral.MessageStoreConfiguration>(this.Path(), null, cancellationToken);
        }

        /// <summary>
        /// Operation: Update Message Store Configuration
        /// HTTP Method: PUT
        /// Endpoint: /restapi/v1.0/account/{accountId}/message-store-configuration
        /// Rate Limit Group: Light
        /// App Permission: EditAccounts
        /// User Permission: AccountAdministration
        /// </summary>
        public async Task<RingCentral.MessageStoreConfiguration> Put(
            RingCentral.MessageStoreConfiguration messageStoreConfiguration,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Put<RingCentral.MessageStoreConfiguration>(this.Path(), messageStoreConfiguration, null,
                cancellationToken);
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