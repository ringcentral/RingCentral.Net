using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.Extension.SmsRecipients
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
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/sms-recipients";
        }
        /// <summary>
        /// Returns a list of Extension's SMS recipients.
        /// 
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/sms-recipients
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// </summary>
        public async Task<RingCentral.SmsRecipientsResource> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.SmsRecipientsResource>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.SmsRecipients.Index SmsRecipients()
        {
            return new Restapi.Account.Extension.SmsRecipients.Index(this);
        }
    }
}