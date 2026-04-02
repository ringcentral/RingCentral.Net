using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.V2.Accounts.Sms.Consents
{
    public partial class Index
    {
        public RestClient rc;
public Restapi.V2.Accounts.Sms.Index parent;
public Index(Restapi.V2.Accounts.Sms.Index parent)
      {
this.parent = parent;
this.rc = parent.rc;
}
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/consents";
        }
        /// <summary>
        /// Returns a list of account-level SMS consent records for opted-out and/or opted-in phone numbers.
/// 
        /// HTTP Method: get
        /// Endpoint: /restapi/v2/accounts/{accountId}/sms/consents
        /// Rate Limit Group: Light
        /// App Permission: SMS
        /// </summary>
  public async Task<RingCentral.OptRecordList> Get(RingCentral.ListSmsConsentRecordsParameters queryParams = null, RestRequestConfig restRequestConfig = null)
  {
return await rc.Get<RingCentral.OptRecordList>(this.Path(), queryParams, restRequestConfig);
  }

        /// <summary>
        /// Adds or updates SMS consent records.
/// 
        /// HTTP Method: patch
        /// Endpoint: /restapi/v2/accounts/{accountId}/sms/consents
        /// Rate Limit Group: Light
        /// App Permission: SMS
        /// </summary>
  public async Task<RingCentral.OptRecordsModificationSummary> Patch(RingCentral.UpdateOptRecordList updateOptRecordList, RestRequestConfig restRequestConfig = null)
  {
return await rc.Patch<RingCentral.OptRecordsModificationSummary>(this.Path(), updateOptRecordList, null, restRequestConfig);
  }
    }
}

namespace RingCentral.Paths.Restapi.V2.Accounts.Sms
{
    public partial class Index
    {
        public Restapi.V2.Accounts.Sms.Consents.Index Consents()
        {
            return new Restapi.V2.Accounts.Sms.Consents.Index(this);
        }
    }
}