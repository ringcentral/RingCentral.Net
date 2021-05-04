using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.Extension.CallerBlocking.PhoneNumbers
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Extension.CallerBlocking.Index parent;
        public string blockedNumberId;

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
        /// Returns the lists of blocked and allowed phone numbers.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// User Permission: ReadBlockedNumbers
        /// </summary>
        public async Task<RingCentral.BlockedAllowedPhoneNumbersList> List(
            RingCentral.ListBlockedAllowedNumbersParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.BlockedAllowedPhoneNumbersList>(this.Path(false), queryParams,
                restRequestConfig);
        }

        /// <summary>
        /// Updates either blocked or allowed phone number list with a new phone number.
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers
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
        /// Returns blocked or allowed phone number(s) by their ID(s). Batch request is supported.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers/{blockedNumberId}
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// User Permission: ReadBlockedNumbers
        /// </summary>
        public async Task<RingCentral.BlockedAllowedPhoneNumberInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            if (blockedNumberId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(blockedNumberId));
            }

            return await rc.Get<RingCentral.BlockedAllowedPhoneNumberInfo>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Updates blocked or allowed phone number(s) by their ID(s). Batch request is supported.
        /// HTTP Method: put
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers/{blockedNumberId}
        /// Rate Limit Group: Medium
        /// App Permission: EditExtensions
        /// User Permission: EditBlockedNumbers
        /// </summary>
        public async Task<RingCentral.BlockedAllowedPhoneNumberInfo> Put(
            RingCentral.AddBlockedAllowedPhoneNumber addBlockedAllowedPhoneNumber,
            RestRequestConfig restRequestConfig = null)
        {
            if (blockedNumberId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(blockedNumberId));
            }

            return await rc.Put<RingCentral.BlockedAllowedPhoneNumberInfo>(this.Path(), addBlockedAllowedPhoneNumber,
                null, restRequestConfig);
        }

        /// <summary>
        /// Deletes blocked or allowed phone number(s) by their ID(s). Batch request is supported.
        /// HTTP Method: delete
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers/{blockedNumberId}
        /// Rate Limit Group: Medium
        /// App Permission: EditExtensions
        /// User Permission: EditBlockedNumbers
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            if (blockedNumberId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(blockedNumberId));
            }

            return await rc.Delete<string>(this.Path(), null, restRequestConfig);
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