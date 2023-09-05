using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.Greeting
{
    public partial class Index
    {
        public string greetingId;
        public Extension.Index parent;
        public RestClient rc;

        public Index(Extension.Index parent, string greetingId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.greetingId = greetingId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && greetingId != null) return $"{parent.Path()}/greeting/{greetingId}";
            return $"{parent.Path()}/greeting";
        }

        /// <summary>
        ///     Creates custom greeting for an extension user.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/greeting
        ///     Rate Limit Group: Heavy
        ///     App Permission: EditExtensions
        ///     User Permission: EditUserAnsweringRules
        /// </summary>
        public async Task<CustomUserGreetingInfo> Post(CreateCustomUserGreetingRequest createCustomUserGreetingRequest,
            CreateCustomUserGreetingParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            var multipartFormDataContent = Utils.GetMultipartFormDataContent(createCustomUserGreetingRequest);
            return await rc.Post<CustomUserGreetingInfo>(Path(false), multipartFormDataContent, queryParams,
                restRequestConfig);
        }

        /// <summary>
        ///     Returns a custom user greeting by ID.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/greeting/{greetingId}
        ///     Rate Limit Group: Medium
        ///     App Permission: ReadAccounts
        ///     User Permission: ReadUserInfo
        /// </summary>
        public async Task<CustomUserGreetingInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            if (greetingId == null) throw new ArgumentException("Parameter cannot be null", nameof(greetingId));
            return await rc.Get<CustomUserGreetingInfo>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Greeting.Index Greeting(string greetingId = null)
        {
            return new Greeting.Index(this, greetingId);
        }
    }
}