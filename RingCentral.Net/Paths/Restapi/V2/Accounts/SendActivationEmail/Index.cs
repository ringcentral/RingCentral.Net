using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.V2.Accounts.SendActivationEmail
{
    public partial class Index
    {
        public RestClient rc;
public Restapi.V2.Accounts.Index parent;
public Index(Restapi.V2.Accounts.Index parent)
      {
this.parent = parent;
this.rc = parent.rc;
}
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/send-activation-email";
        }
        /// <summary>
        /// Sends/resends activation email to the system user of unconfirmed account.
        /// HTTP Method: post
        /// Endpoint: /restapi/v2/accounts/{accountId}/send-activation-email
        /// Rate Limit Group: Medium
        /// App Permission: EditAccounts
        /// User Permission: AccountAdministration
        /// </summary>
  public async Task<string> Post(RestRequestConfig restRequestConfig = null)
  {
return await rc.Post<string>(this.Path(), null, null, restRequestConfig);
  }
    }
}

namespace RingCentral.Paths.Restapi.V2.Accounts
{
    public partial class Index
    {
        public Restapi.V2.Accounts.SendActivationEmail.Index SendActivationEmail()
        {
            return new Restapi.V2.Accounts.SendActivationEmail.Index(this);
        }
    }
}