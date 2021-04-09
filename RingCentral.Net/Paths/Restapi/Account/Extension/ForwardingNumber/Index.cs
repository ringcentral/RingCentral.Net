using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.ForwardingNumber
{
    public class Index
    {
        public string forwardingNumberId;
        public Extension.Index parent;
        public RestClient rc;

        public Index(Extension.Index parent, string forwardingNumberId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.forwardingNumberId = forwardingNumberId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && forwardingNumberId != null)
                return $"{parent.Path()}/forwarding-number/{forwardingNumberId}";
            return $"{parent.Path()}/forwarding-number";
        }

        /// <summary>
        ///     Returns the list of extension phone numbers used for call forwarding and call flip. The returned list contains all
        ///     the extension phone numbers used for call forwarding and call flip.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/forwarding-number
        ///     Rate Limit Group: Light
        ///     App Permission: ReadAccounts
        ///     User Permission: ReadUserForwardingFlipNumbers
        /// </summary>
        public async Task<GetExtensionForwardingNumberListResponse> List(
            ListForwardingNumbersParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<GetExtensionForwardingNumberListResponse>(Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Adds a new forwarding number to the forwarding number list.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/forwarding-number
        ///     Rate Limit Group: Medium
        ///     App Permission: EditExtensions
        ///     User Permission: EditUserForwardingFlipNumbers
        /// </summary>
        public async Task<ForwardingNumberInfo> Post(CreateForwardingNumberRequest createForwardingNumberRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<ForwardingNumberInfo>(Path(false), createForwardingNumberRequest, null,
                restRequestConfig);
        }

        /// <summary>
        ///     Returns a specific forwarding number.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/forwarding-number/{forwardingNumberId}
        ///     Rate Limit Group: Light
        ///     App Permission: ReadAccounts
        ///     User Permission: ReadUserForwardingFlipNumbers
        /// </summary>
        public async Task<ForwardingNumberInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<ForwardingNumberInfo>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Updates the existing forwarding number from the forwarding number list.
        ///     HTTP Method: put
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/forwarding-number/{forwardingNumberId}
        ///     Rate Limit Group: Medium
        ///     App Permission: EditExtensions
        ///     User Permission: EditUserForwardingFlipNumbers
        /// </summary>
        public async Task<ForwardingNumberInfo> Put(UpdateForwardingNumberRequest updateForwardingNumberRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Put<ForwardingNumberInfo>(Path(), updateForwardingNumberRequest, null, restRequestConfig);
        }

        /// <summary>
        ///     Deletes a forwarding number from the forwarding number list by its ID.
        ///     HTTP Method: delete
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/forwarding-number/{forwardingNumberId}
        ///     Rate Limit Group: Medium
        ///     App Permission: EditExtensions
        ///     User Permission: EditUserForwardingFlipNumbers
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Delete<string>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public ForwardingNumber.Index ForwardingNumber(string forwardingNumberId = null)
        {
            return new ForwardingNumber.Index(this, forwardingNumberId);
        }
    }
}