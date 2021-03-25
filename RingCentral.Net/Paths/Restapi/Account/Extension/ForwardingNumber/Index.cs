using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.ForwardingNumber
{
    public partial class Index
    {
        public RestClient rc;
        public string forwardingNumberId;
        public Restapi.Account.Extension.Index parent;

        public Index(Restapi.Account.Extension.Index parent, string forwardingNumberId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.forwardingNumberId = forwardingNumberId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && forwardingNumberId != null)
            {
                return $"{parent.Path()}/forwarding-number/{forwardingNumberId}";
            }

            return $"{parent.Path()}/forwarding-number";
        }

        /// <summary>
        /// Returns the list of extension phone numbers used for call forwarding and call flip. The returned list contains all the extension phone numbers used for call forwarding and call flip.
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/forwarding-number
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// User Permission: ReadUserForwardingFlipNumbers
        /// </summary>
        public async Task<RingCentral.GetExtensionForwardingNumberListResponse> List(
            ListForwardingNumbersParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.GetExtensionForwardingNumberListResponse>(this.Path(false), queryParams,
                restRequestConfig);
        }

        /// <summary>
        /// Adds a new forwarding number to the forwarding number list.
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/forwarding-number
        /// Rate Limit Group: Medium
        /// App Permission: EditExtensions
        /// User Permission: EditUserForwardingFlipNumbers
        /// </summary>
        public async Task<RingCentral.ForwardingNumberInfo> Post(
            RingCentral.CreateForwardingNumberRequest createForwardingNumberRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.ForwardingNumberInfo>(this.Path(false), createForwardingNumberRequest,
                null, restRequestConfig);
        }

        /// <summary>
        /// Returns a specific forwarding number.
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/forwarding-number/{forwardingNumberId}
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// User Permission: ReadUserForwardingFlipNumbers
        /// </summary>
        public async Task<RingCentral.ForwardingNumberInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            if (this.forwardingNumberId == null)
            {
                throw new System.ArgumentNullException("forwardingNumberId");
            }

            return await rc.Get<RingCentral.ForwardingNumberInfo>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Updates the existing forwarding number from the forwarding number list.
        /// HTTP Method: PUT
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/forwarding-number/{forwardingNumberId}
        /// Rate Limit Group: Medium
        /// App Permission: EditExtensions
        /// User Permission: EditUserForwardingFlipNumbers
        /// </summary>
        public async Task<RingCentral.ForwardingNumberInfo> Put(
            RingCentral.UpdateForwardingNumberRequest updateForwardingNumberRequest,
            RestRequestConfig restRequestConfig = null)
        {
            if (this.forwardingNumberId == null)
            {
                throw new System.ArgumentNullException("forwardingNumberId");
            }

            return await rc.Put<RingCentral.ForwardingNumberInfo>(this.Path(), updateForwardingNumberRequest, null,
                restRequestConfig);
        }

        /// <summary>
        /// Deletes a forwarding number from the forwarding number list by its ID.
        /// HTTP Method: DELETE
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/forwarding-number/{forwardingNumberId}
        /// Rate Limit Group: Medium
        /// App Permission: EditExtensions
        /// User Permission: EditUserForwardingFlipNumbers
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            if (this.forwardingNumberId == null)
            {
                throw new System.ArgumentNullException("forwardingNumberId");
            }

            return await rc.Delete<string>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.ForwardingNumber.Index ForwardingNumber(string forwardingNumberId = null)
        {
            return new Restapi.Account.Extension.ForwardingNumber.Index(this, forwardingNumberId);
        }
    }
}