using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.V2.Accounts.PhoneNumbers.BulkAdd
{
    public class Index
    {
        public PhoneNumbers.Index parent;
        public RestClient rc;
        public string taskId;

        public Index(PhoneNumbers.Index parent, string taskId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.taskId = taskId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && taskId != null) return $"{parent.Path()}/bulk-add/{taskId}";
            return $"{parent.Path()}/bulk-add";
        }

        /// <summary>
        ///     Adds phone numbers to the account Inventory as unassigned. Currently, we support the following values: `Inventory`,
        ///     `InventoryPartnerBusinessMobileNumber` and `PartnerBusinessMobileNumber`. Later we may support some other values
        ///     like `ForwardedNumber`, etc.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/v2/accounts/{accountId}/phone-numbers/bulk-add
        ///     Rate Limit Group: Heavy
        ///     App Permission: EditAccounts
        ///     User Permission: EditCompanyPhoneNumbers
        /// </summary>
        public async Task<AddPhoneNumbersResponse> Post(AddPhoneNumbersRequest addPhoneNumbersRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<AddPhoneNumbersResponse>(Path(false), addPhoneNumbersRequest, null, restRequestConfig);
        }

        /// <summary>
        ///     Returns the result of asynchronous operation which adds phone numbers to the account inventory.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/v2/accounts/{accountId}/phone-numbers/bulk-add/{taskId}
        ///     Rate Limit Group: Heavy
        ///     App Permission: EditAccounts
        ///     User Permission: EditCompanyPhoneNumbers
        /// </summary>
        public async Task<GetBulkAddTaskResultsV2Response> Get(RestRequestConfig restRequestConfig = null)
        {
            if (taskId == null) throw new ArgumentException("Parameter cannot be null", nameof(taskId));
            return await rc.Get<GetBulkAddTaskResultsV2Response>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.V2.Accounts.PhoneNumbers
{
    public partial class Index
    {
        public BulkAdd.Index BulkAdd(string taskId = null)
        {
            return new BulkAdd.Index(this, taskId);
        }
    }
}