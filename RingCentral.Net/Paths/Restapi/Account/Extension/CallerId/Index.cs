using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.CallerId
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Extension.Index parent;

        public Index(Restapi.Account.Extension.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/caller-id";
        }

        /// <summary>
        /// Returns information on an outbound caller ID of an extension.
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-id
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// User Permission: ReadCallerIDSettings
        /// </summary>
        public async Task<RingCentral.ExtensionCallerIdInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.ExtensionCallerIdInfo>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Updates outbound caller ID information of an extension.
        /// HTTP Method: PUT
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-id
        /// Rate Limit Group: Medium
        /// App Permission: EditExtensions
        /// User Permission: EditCallerIDSettings
        /// </summary>
        public async Task<RingCentral.ExtensionCallerIdInfo> Put(
            RingCentral.ExtensionCallerIdInfo extensionCallerIdInfo, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Put<RingCentral.ExtensionCallerIdInfo>(this.Path(), extensionCallerIdInfo, null,
                restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.CallerId.Index CallerId()
        {
            return new Restapi.Account.Extension.CallerId.Index(this);
        }
    }
}