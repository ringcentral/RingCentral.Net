using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.V2.Accounts.Sms.Consents.Export
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
            return $"{parent.Path()}/export";
        }
        /// <summary>
        /// Returns a list of account-level SMS consent records for opted-out and/or opted-in phone numbers in CSV format.
/// The following columns will be included in the resulted CSV file:
/// 
/// | Column name           | Data type | Description                                                      |
/// |-----------------------|-----------|------------------------------------------------------------------|
/// | External Party Number | string    | Sender's number in E.164 format                                  |
/// | Internal Party Number | string    | Recipient's number in E.164 format                               |
/// | Consent Status        | string    | Consent status, either "OptOut" or "OptIn"                       |
/// | Source                | string    | Source of the consent record                                     |
/// | Coverage              | string    | Coverage of this consent record (Account is returned as Company) |
/// | Campaign Type         | string    | Campaign type for this consent record                            |
/// | Notes                 | string    | Notes and comments regarding this consent record                 |
/// | Last Modified Time    | string    | Last Modified Time in ISO 8601 format                            |
/// 
        /// HTTP Method: get
        /// Endpoint: /restapi/v2/accounts/{accountId}/sms/consents/export
        /// Rate Limit Group: Light
        /// App Permission: SMS
        /// </summary>
  public async Task<string> Get(RestRequestConfig restRequestConfig = null)
  {
return await rc.Get<string>(this.Path(), null, restRequestConfig);
  }
    }
}

namespace RingCentral.Paths.Restapi.V2.Accounts.Sms.Consents
{
    public partial class Index
    {
        public Restapi.V2.Accounts.Sms.Consents.Export.Index Export()
        {
            return new Restapi.V2.Accounts.Sms.Consents.Export.Index(this);
        }
    }
}