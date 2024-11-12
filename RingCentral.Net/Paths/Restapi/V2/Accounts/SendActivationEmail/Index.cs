using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.V2.Accounts.SendActivationEmail
{
    public class Index
    {
        public Accounts.Index parent;
        public RestClient rc;

        public Index(Accounts.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/send-activation-email";
        }

        /// <summary>
        ///     Sends/resends activation email to the system user of unconfirmed account.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/v2/accounts/{accountId}/send-activation-email
        ///     Rate Limit Group: Medium
        ///     App Permission: EditAccounts
        ///     User Permission: AccountAdministration
        /// </summary>
        public async Task<string> Post(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<string>(Path(), null, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.V2.Accounts
{
    public partial class Index
    {
        public SendActivationEmail.Index SendActivationEmail()
        {
            return new SendActivationEmail.Index(this);
        }
    }
}