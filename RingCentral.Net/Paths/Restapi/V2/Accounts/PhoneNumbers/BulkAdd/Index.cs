using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.V2.Accounts.PhoneNumbers.BulkAdd
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.V2.Accounts.PhoneNumbers.Index parent;
        public string taskId;
        public Index(Restapi.V2.Accounts.PhoneNumbers.Index parent, string taskId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.taskId = taskId;
        }
        public string Path(bool withParameter = true)
        {
            if (withParameter && taskId != null)
            {
                return $"{parent.Path()}/bulk-add/{taskId}";
            }
            return $"{parent.Path()}/bulk-add";
        }
        /// <summary>
        /// Adds phone numbers to the account Inventory as unassigned. Currently, we support the following values: `Inventory`,
        /// `InventoryPartnerBusinessMobileNumber`, `PartnerBusinessMobileNumber`, `InventoryMobileNumber`.
        /// Later we may support some other values like `ForwardedNumber`, etc.
        /// 
        /// HTTP Method: post
        /// Endpoint: /restapi/v2/accounts/{accountId}/phone-numbers/bulk-add
        /// Rate Limit Group: Heavy
        /// App Permission: EditAccounts
        /// User Permission: EditCompanyPhoneNumbers
        /// </summary>
        public async Task<RingCentral.AddPhoneNumbersResponse> Post(RingCentral.AddPhoneNumbersRequest addPhoneNumbersRequest, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.AddPhoneNumbersResponse>(this.Path(false), addPhoneNumbersRequest, null, restRequestConfig);
        }

        /// <summary>
        /// Returns the result of asynchronous operation which adds phone numbers to the account inventory.
        /// 
        /// HTTP Method: get
        /// Endpoint: /restapi/v2/accounts/{accountId}/phone-numbers/bulk-add/{taskId}
        /// Rate Limit Group: Heavy
        /// App Permission: EditAccounts
        /// User Permission: EditCompanyPhoneNumbers
        /// </summary>
        public async Task<RingCentral.GetBulkAddTaskResultsV2Response> Get(RestRequestConfig restRequestConfig = null)
        {
            if (taskId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(taskId));
            }
            return await rc.Get<RingCentral.GetBulkAddTaskResultsV2Response>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.V2.Accounts.PhoneNumbers
{
    public partial class Index
    {
        public Restapi.V2.Accounts.PhoneNumbers.BulkAdd.Index BulkAdd(string taskId = null)
        {
            return new Restapi.V2.Accounts.PhoneNumbers.BulkAdd.Index(this, taskId);
        }
    }
}