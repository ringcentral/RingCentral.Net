using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.IvrPrompts
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Index parent;
        public string promptId;

        public Index(Restapi.Account.Index parent, string promptId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.promptId = promptId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && promptId != null)
            {
                return $"{parent.Path()}/ivr-prompts/{promptId}";
            }

            return $"{parent.Path()}/ivr-prompts";
        }

        /// <summary>
        /// Returns the list of IVR prompts.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/ivr-prompts
        /// Rate Limit Group: Medium
        /// App Permission: ReadAccounts
        /// User Permission: ReadCompanyGreetings
        /// </summary>
        public async Task<RingCentral.IVRPrompts> List(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.IVRPrompts>(this.Path(false), null, restRequestConfig);
        }

        /// <summary>
        /// Creates an IVR prompt.
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/ivr-prompts
        /// Rate Limit Group: Heavy
        /// App Permission: EditAccounts
        /// User Permission: EditCompanyGreetings
        /// </summary>
        public async Task<RingCentral.PromptInfo> Post(RingCentral.CreateIVRPromptRequest createIVRPromptRequest,
            RestRequestConfig restRequestConfig = null)
        {
            var multipartFormDataContent = Utils.GetMultipartFormDataContent(createIVRPromptRequest);
            return await rc.Post<RingCentral.PromptInfo>(this.Path(false), multipartFormDataContent, null,
                restRequestConfig);
        }

        /// <summary>
        /// Returns an IVR prompt by ID.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/ivr-prompts/{promptId}
        /// Rate Limit Group: Medium
        /// App Permission: ReadAccounts
        /// User Permission: ReadCompanyGreetings
        /// </summary>
        public async Task<RingCentral.PromptInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.PromptInfo>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Updates an IVR prompt by ID
        /// HTTP Method: put
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/ivr-prompts/{promptId}
        /// Rate Limit Group: Medium
        /// App Permission: EditAccounts
        /// User Permission: EditCompanyGreetings
        /// </summary>
        public async Task<RingCentral.PromptInfo> Put(RingCentral.UpdateIVRPromptRequest updateIVRPromptRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Put<RingCentral.PromptInfo>(this.Path(), updateIVRPromptRequest, null, restRequestConfig);
        }

        /// <summary>
        /// Deletes an IVR prompt by ID.
        /// HTTP Method: delete
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/ivr-prompts/{promptId}
        /// Rate Limit Group: Heavy
        /// App Permission: EditAccounts
        /// User Permission: EditCompanyGreetings
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Delete<string>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public Restapi.Account.IvrPrompts.Index IvrPrompts(string promptId = null)
        {
            return new Restapi.Account.IvrPrompts.Index(this, promptId);
        }
    }
}