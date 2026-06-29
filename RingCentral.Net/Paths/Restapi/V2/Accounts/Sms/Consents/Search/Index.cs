using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.V2.Accounts.Sms.Consents.Search
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
            return $"{parent.Path()}/search";
        }
        /// <summary>
        /// Returns the list of account-level SMS consent records according to the search criteria.
        /// 
        /// HTTP Method: post
        /// Endpoint: /restapi/v2/accounts/{accountId}/sms/consents/search
        /// Rate Limit Group: Light
        /// App Permission: SMS
        /// </summary>
        public async Task<RingCentral.OptRecordList> Post(RingCentral.SearchSmsConsentRecordsRequest searchSmsConsentRecordsRequest, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.OptRecordList>(this.Path(), searchSmsConsentRecordsRequest, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.V2.Accounts.Sms.Consents
{
    public partial class Index
    {
        public Restapi.V2.Accounts.Sms.Consents.Search.Index Search()
        {
            return new Restapi.V2.Accounts.Sms.Consents.Search.Index(this);
        }
    }
}