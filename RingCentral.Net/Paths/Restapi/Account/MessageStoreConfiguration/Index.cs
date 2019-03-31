using System.Threading.Tasks;

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
        /// Http Get /restapi/v1.0/account/{accountId}/message-store-configuration
        /// </summary>
        public async Task<RingCentral.MessageStoreConfiguration> Get()
        {
            return await rc.Get<RingCentral.MessageStoreConfiguration>(this.Path());
        }

        /// <summary>
        /// Operation: Update Message Store Configuration
        /// Http Put /restapi/v1.0/account/{accountId}/message-store-configuration
        /// </summary>
        public async Task<RingCentral.MessageStoreConfiguration> Put(
            RingCentral.MessageStoreConfiguration messageStoreConfiguration)
        {
            return await rc.Put<RingCentral.MessageStoreConfiguration>(this.Path(), messageStoreConfiguration);
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