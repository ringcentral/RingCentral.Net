using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.CallerId
{
    public class Index
    {
        public Extension.Index parent;
        public RestClient rc;

        public Index(Extension.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/caller-id";
        }

        /// <summary>
        ///     Returns information on an outbound caller ID of an extension.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/caller-id
        ///     Rate Limit Group: Light
        ///     App Permission: ReadAccounts
        ///     User Permission: ReadCallerIDSettings
        /// </summary>
        public async Task<ExtensionCallerIdInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<ExtensionCallerIdInfo>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Updates outbound caller ID information of an extension.
        ///     HTTP Method: put
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/caller-id
        ///     Rate Limit Group: Medium
        ///     App Permission: EditExtensions
        ///     User Permission: EditCallerIDSettings
        /// </summary>
        public async Task<ExtensionCallerIdInfo> Put(
            ExtensionCallerIdInfo extensionCallerIdInfo, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Put<ExtensionCallerIdInfo>(Path(), extensionCallerIdInfo, null,
                restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public CallerId.Index CallerId()
        {
            return new CallerId.Index(this);
        }
    }
}