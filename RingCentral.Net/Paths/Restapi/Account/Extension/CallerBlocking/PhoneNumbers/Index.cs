using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.CallerBlocking.PhoneNumbers
{
    public partial class Index
    {
        public RestClient rc;
        public string blockedNumberId;
        public Restapi.Account.Extension.CallerBlocking.Index parent;

        public Index(Restapi.Account.Extension.CallerBlocking.Index parent, string blockedNumberId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.blockedNumberId = blockedNumberId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && blockedNumberId != null)
            {
                return $"{parent.Path()}/phone-numbers/{blockedNumberId}";
            }

            return $"{parent.Path()}/phone-numbers";
        }

        /// <summary>
        /// Operation: Get Blocked/Allowed Phone Numbers
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// User Permission: ReadBlockedNumbers
        /// </summary>
        public async Task<RingCentral.BlockedAllowedPhoneNumbersList> List(
            ListBlockedAllowedNumbersParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.BlockedAllowedPhoneNumbersList>(this.Path(false), queryParams,
                restRequestConfig);
        }

        /// <summary>
        /// Operation: Add Blocked/Allowed Number
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers
        /// Rate Limit Group: Medium
        /// App Permission: EditExtensions
        /// User Permission: EditBlockedNumbers
        /// </summary>
        public async Task<RingCentral.BlockedAllowedPhoneNumberInfo> Post(
            RingCentral.AddBlockedAllowedPhoneNumber addBlockedAllowedPhoneNumber,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.BlockedAllowedPhoneNumberInfo>(this.Path(false),
                addBlockedAllowedPhoneNumber, null, restRequestConfig);
        }

        /// <summary>
        /// Operation: Get Blocked/Allowed Number
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers/{blockedNumberId}
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// User Permission: ReadBlockedNumbers
        /// </summary>
        public async Task<RingCentral.BlockedAllowedPhoneNumberInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            if (this.blockedNumberId == null)
            {
                throw new System.ArgumentNullException("blockedNumberId");
            }

            return await rc.Get<RingCentral.BlockedAllowedPhoneNumberInfo>(this.Path(), null, restRequestConfig);
        }

        public async Task<BatchResponse<RingCentral.BlockedAllowedPhoneNumberInfo>[]> BatchGet(
            RestRequestConfig restRequestConfig = null)
        {
            if (!this.Path().Contains(","))
            {
                throw new System.ArgumentException(
                    "In order to make a BatchGet, please specify multiple IDs delimited by ','");
            }

            return await rc.BatchGet<RingCentral.BlockedAllowedPhoneNumberInfo>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Operation: Delete Blocked/Allowed Number
        /// HTTP Method: DELETE
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers/{blockedNumberId}
        /// Rate Limit Group: Medium
        /// App Permission: EditExtensions
        /// User Permission: EditBlockedNumbers
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            if (this.blockedNumberId == null)
            {
                throw new System.ArgumentNullException("blockedNumberId");
            }

            return await rc.Delete<string>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Operation: Update Blocked/Allowed Number
        /// HTTP Method: PUT
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers/{blockedNumberId}
        /// Rate Limit Group: Medium
        /// App Permission: EditExtensions
        /// User Permission: EditBlockedNumbers
        /// </summary>
        public async Task<RingCentral.BlockedAllowedPhoneNumberInfo> Put(
            RingCentral.AddBlockedAllowedPhoneNumber addBlockedAllowedPhoneNumber,
            RestRequestConfig restRequestConfig = null)
        {
            if (this.blockedNumberId == null)
            {
                throw new System.ArgumentNullException("blockedNumberId");
            }

            return await rc.Put<RingCentral.BlockedAllowedPhoneNumberInfo>(this.Path(), addBlockedAllowedPhoneNumber,
                null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension.CallerBlocking
{
    public partial class Index
    {
        public Restapi.Account.Extension.CallerBlocking.PhoneNumbers.Index PhoneNumbers(string blockedNumberId = null)
        {
            return new Restapi.Account.Extension.CallerBlocking.PhoneNumbers.Index(this, blockedNumberId);
        }
    }
}