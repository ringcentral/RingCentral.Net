using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Greeting
{
    public class Index
    {
        public Account.Index parent;
        public RestClient rc;

        public Index(Account.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/greeting";
        }

        /// <summary>
        ///     Creates a custom company greeting.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/greeting
        ///     Rate Limit Group: Medium
        ///     App Permission: EditAccounts
        ///     User Permission: ReadUserInfo
        /// </summary>
        public async Task<CustomCompanyGreetingInfo> Post(CreateCompanyGreetingRequest createCompanyGreetingRequest,
            RestRequestConfig restRequestConfig = null)
        {
            var multipartFormDataContent = Utils.GetMultipartFormDataContent(createCompanyGreetingRequest);
            return await rc.Post<CustomCompanyGreetingInfo>(Path(), multipartFormDataContent, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public Greeting.Index Greeting()
        {
            return new Greeting.Index(this);
        }
    }
}