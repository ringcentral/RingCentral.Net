using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

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
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/caller-id
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
        /// HTTP Method: put
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/caller-id
        /// Rate Limit Group: Medium
        /// App Permission: EditExtensions
        /// User Permission: EditCallerIDSettings
        /// </summary>
        public async Task<RingCentral.ExtensionCallerIdInfo> Put(
            RingCentral.ExtensionCallerIdInfoRequest extensionCallerIdInfoRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Put<RingCentral.ExtensionCallerIdInfo>(this.Path(), extensionCallerIdInfoRequest, null,
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