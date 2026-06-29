using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.Extension.SmsRecipients.BulkAssign
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Extension.SmsRecipients.Index parent;
        public Index(Restapi.Account.Extension.SmsRecipients.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/bulk-assign";
        }
        /// <summary>
        /// Updates the list of SMS recipients for a given extension.
        /// 
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/sms-recipients/bulk-assign
        /// Rate Limit Group: Medium
        /// App Permission: EditExtensions
        /// </summary>
        public async Task<string> Post(RingCentral.BulkAssignSmsRecipientsRequest bulkAssignSmsRecipientsRequest, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<string>(this.Path(), bulkAssignSmsRecipientsRequest, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension.SmsRecipients
{
    public partial class Index
    {
        public Restapi.Account.Extension.SmsRecipients.BulkAssign.Index BulkAssign()
        {
            return new Restapi.Account.Extension.SmsRecipients.BulkAssign.Index(this);
        }
    }
}