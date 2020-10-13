using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Account.Extension.Greeting
{
    public partial class Index
    {
        public RestClient rc;
        public string greetingId;
        public Restapi.Account.Extension.Index parent;

        public Index(Restapi.Account.Extension.Index parent, string greetingId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.greetingId = greetingId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && greetingId != null)
            {
                return $"{parent.Path()}/greeting/{greetingId}";
            }

            return $"{parent.Path()}/greeting";
        }

        /// <summary>
        /// Operation: Create Custom User Greeting
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/greeting
        /// Rate Limit Group: Heavy
        /// App Permission: EditExtensions
        /// User Permission: EditUserAnsweringRules
        /// </summary>
        public async Task<RingCentral.CustomUserGreetingInfo> Post(
            CreateCustomUserGreetingRequest createCustomUserGreetingRequest,
            CreateCustomUserGreetingParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            var multipartFormDataContent = Utils.GetMultipartFormDataContent(createCustomUserGreetingRequest);
            return await rc.Post<RingCentral.CustomUserGreetingInfo>(this.Path(false), multipartFormDataContent,
                queryParams, restRequestConfig);
        }

        /// <summary>
        /// Operation: Get Custom Greeting
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/greeting/{greetingId}
        /// Rate Limit Group: Medium
        /// App Permission: ReadAccounts
        /// User Permission: ReadUserInfo
        /// </summary>
        public async Task<RingCentral.CustomUserGreetingInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            if (this.greetingId == null)
            {
                throw new System.ArgumentNullException("greetingId");
            }

            return await rc.Get<RingCentral.CustomUserGreetingInfo>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.Greeting.Index Greeting(string greetingId = null)
        {
            return new Restapi.Account.Extension.Greeting.Index(this, greetingId);
        }
    }
}