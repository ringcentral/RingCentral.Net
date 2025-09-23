using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.V2.Accounts.SendWelcomeEmail
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
            return $"{parent.Path()}/send-welcome-email";
        }

        /// <summary>
        ///     Sends or re-sends welcome email to the system user of confirmed account
        ///     HTTP Method: post
        ///     Endpoint: /restapi/v2/accounts/{accountId}/send-welcome-email
        ///     Rate Limit Group: Medium
        ///     App Permission: EditExtensions
        ///     User Permission: Users
        /// </summary>
        public async Task<string> Post(SendWelcomeEmailV2Request sendWelcomeEmailV2Request,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<string>(Path(), sendWelcomeEmailV2Request, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.V2.Accounts
{
    public partial class Index
    {
        public SendWelcomeEmail.Index SendWelcomeEmail()
        {
            return new SendWelcomeEmail.Index(this);
        }
    }
}