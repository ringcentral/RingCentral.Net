using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.CallerBlocking.PhoneNumbers
{
    public class Index
    {
        public string blockedNumberId;
        public CallerBlocking.Index parent;
        public RestClient rc;

        public Index(CallerBlocking.Index parent, string blockedNumberId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.blockedNumberId = blockedNumberId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && blockedNumberId != null) return $"{parent.Path()}/phone-numbers/{blockedNumberId}";
            return $"{parent.Path()}/phone-numbers";
        }

        /// <summary>
        ///     Returns the lists of blocked and allowed phone numbers.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers
        ///     Rate Limit Group: Light
        ///     App Permission: ReadAccounts
        ///     User Permission: ReadBlockedNumbers
        /// </summary>
        public async Task<BlockedAllowedPhoneNumbersList> List(ListBlockedAllowedNumbersParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<BlockedAllowedPhoneNumbersList>(Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Updates either blocked or allowed phone number list with a new phone number.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers
        ///     Rate Limit Group: Medium
        ///     App Permission: EditExtensions
        ///     User Permission: EditBlockedNumbers
        /// </summary>
        public async Task<BlockedAllowedPhoneNumberInfo> Post(AddBlockedAllowedPhoneNumber addBlockedAllowedPhoneNumber,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<BlockedAllowedPhoneNumberInfo>(Path(false), addBlockedAllowedPhoneNumber, null,
                restRequestConfig);
        }

        /// <summary>
        ///     Returns blocked or allowed phone number(s) by their ID(s). Batch request is supported.
        ///     HTTP Method: get
        ///     Endpoint:
        ///     /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers/{blockedNumberId}
        ///     Rate Limit Group: Light
        ///     App Permission: ReadAccounts
        ///     User Permission: ReadBlockedNumbers
        /// </summary>
        public async Task<BlockedAllowedPhoneNumberInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<BlockedAllowedPhoneNumberInfo>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Updates blocked or allowed phone number(s) by their ID(s). Batch request is supported.
        ///     HTTP Method: put
        ///     Endpoint:
        ///     /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers/{blockedNumberId}
        ///     Rate Limit Group: Medium
        ///     App Permission: EditExtensions
        ///     User Permission: EditBlockedNumbers
        /// </summary>
        public async Task<BlockedAllowedPhoneNumberInfo> Put(AddBlockedAllowedPhoneNumber addBlockedAllowedPhoneNumber,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Put<BlockedAllowedPhoneNumberInfo>(Path(), addBlockedAllowedPhoneNumber, null,
                restRequestConfig);
        }

        /// <summary>
        ///     Deletes blocked or allowed phone number(s) by their ID(s). Batch request is supported.
        ///     HTTP Method: delete
        ///     Endpoint:
        ///     /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers/{blockedNumberId}
        ///     Rate Limit Group: Medium
        ///     App Permission: EditExtensions
        ///     User Permission: EditBlockedNumbers
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Delete<string>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension.CallerBlocking
{
    public partial class Index
    {
        public PhoneNumbers.Index PhoneNumbers(string blockedNumberId = null)
        {
            return new PhoneNumbers.Index(this, blockedNumberId);
        }
    }
}