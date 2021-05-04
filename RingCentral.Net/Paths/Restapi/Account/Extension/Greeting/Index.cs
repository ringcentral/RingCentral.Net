using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.Extension.Greeting
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Extension.Index parent;
        public string greetingId;

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
        /// Creates custom greeting for an extension user.
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/greeting
        /// Rate Limit Group: Heavy
        /// App Permission: EditExtensions
        /// User Permission: EditUserAnsweringRules
        /// </summary>
        public async Task<RingCentral.CustomUserGreetingInfo> Post(
            RingCentral.CreateCustomUserGreetingRequest createCustomUserGreetingRequest,
            RingCentral.CreateCustomUserGreetingParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            var multipartFormDataContent = Utils.GetMultipartFormDataContent(createCustomUserGreetingRequest);
            return await rc.Post<RingCentral.CustomUserGreetingInfo>(this.Path(false), multipartFormDataContent,
                queryParams, restRequestConfig);
        }

        /// <summary>
        /// Returns a custom user greeting by ID.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/greeting/{greetingId}
        /// Rate Limit Group: Medium
        /// App Permission: ReadAccounts
        /// User Permission: ReadUserInfo
        /// </summary>
        public async Task<RingCentral.CustomUserGreetingInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            if (greetingId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(greetingId));
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