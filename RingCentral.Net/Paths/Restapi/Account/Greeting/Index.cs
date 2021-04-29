using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.Greeting
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Index parent;

        public Index(Restapi.Account.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/greeting";
        }

        /// <summary>
        /// Creates a custom company greeting.
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/greeting
        /// Rate Limit Group: Medium
        /// App Permission: EditAccounts
        /// User Permission: ReadUserInfo
        /// </summary>
        public async Task<RingCentral.CustomCompanyGreetingInfo> Post(
            RingCentral.CreateCompanyGreetingRequest createCompanyGreetingRequest,
            RestRequestConfig restRequestConfig = null)
        {
            var multipartFormDataContent = Utils.GetMultipartFormDataContent(createCompanyGreetingRequest);
            return await rc.Post<RingCentral.CustomCompanyGreetingInfo>(this.Path(), multipartFormDataContent, null,
                restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public Restapi.Account.Greeting.Index Greeting()
        {
            return new Restapi.Account.Greeting.Index(this);
        }
    }
}