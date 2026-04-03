using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.V2.Accounts.SendWelcomeEmail
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
            return $"{parent.Path()}/send-welcome-email";
        }
        /// <summary>
        /// Sends or re-sends welcome email to the system user of confirmed account
        /// HTTP Method: post
        /// Endpoint: /restapi/v2/accounts/{accountId}/send-welcome-email
        /// Rate Limit Group: Medium
        /// App Permission: EditExtensions
        /// User Permission: Users
        /// </summary>
        public async Task<string> Post(RingCentral.SendWelcomeEmailV2Request sendWelcomeEmailV2Request, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<string>(this.Path(), sendWelcomeEmailV2Request, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.V2.Accounts
{
    public partial class Index
    {
        public Restapi.V2.Accounts.SendWelcomeEmail.Index SendWelcomeEmail()
        {
            return new Restapi.V2.Accounts.SendWelcomeEmail.Index(this);
        }
    }
}