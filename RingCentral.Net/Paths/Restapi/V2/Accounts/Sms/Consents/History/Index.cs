using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.V2.Accounts.Sms.Consents.History
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.V2.Accounts.Sms.Consents.Index parent;
        public Index(Restapi.V2.Accounts.Sms.Consents.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/history";
        }
        /// <summary>
        /// Returns the history of SMS consent records for opted-out and/or opted-in phone numbers.
        /// 
        /// HTTP Method: get
        /// Endpoint: /restapi/v2/accounts/{accountId}/sms/consents/history
        /// Rate Limit Group: Light
        /// App Permission: SMS
        /// </summary>
        public async Task<RingCentral.ConsentHistoryRecordList> Get(RingCentral.ListSmsConsentHistoryRecordsParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.ConsentHistoryRecordList>(this.Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.V2.Accounts.Sms.Consents
{
    public partial class Index
    {
        public Restapi.V2.Accounts.Sms.Consents.History.Index History()
        {
            return new Restapi.V2.Accounts.Sms.Consents.History.Index(this);
        }
    }
}