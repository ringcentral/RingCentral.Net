using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.IvrPrompts
{
    public partial class Index
    {
        public Account.Index parent;
        public string promptId;
        public RestClient rc;

        public Index(Account.Index parent, string promptId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.promptId = promptId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && promptId != null) return $"{parent.Path()}/ivr-prompts/{promptId}";
            return $"{parent.Path()}/ivr-prompts";
        }

        /// <summary>
        ///     Returns the list of IVR prompts.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/ivr-prompts
        ///     Rate Limit Group: Medium
        ///     App Permission: ReadAccounts
        ///     User Permission: ReadCompanyGreetings
        /// </summary>
        public async Task<RingCentral.IvrPrompts> List(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.IvrPrompts>(Path(false), null, restRequestConfig);
        }

        /// <summary>
        ///     Creates an IVR prompt.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/ivr-prompts
        ///     Rate Limit Group: Heavy
        ///     App Permission: EditAccounts
        ///     User Permission: EditCompanyGreetings
        /// </summary>
        public async Task<PromptInfo> Post(CreateIVRPromptRequest createIVRPromptRequest,
            RestRequestConfig restRequestConfig = null)
        {
            var multipartFormDataContent = Utils.GetMultipartFormDataContent(createIVRPromptRequest);
            return await rc.Post<PromptInfo>(Path(false), multipartFormDataContent, null, restRequestConfig);
        }

        /// <summary>
        ///     Returns an IVR prompt by ID.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/ivr-prompts/{promptId}
        ///     Rate Limit Group: Medium
        ///     App Permission: ReadAccounts
        ///     User Permission: ReadCompanyGreetings
        /// </summary>
        public async Task<PromptInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            if (promptId == null) throw new ArgumentException("Parameter cannot be null", nameof(promptId));
            return await rc.Get<PromptInfo>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Updates an IVR prompt by ID
        ///     HTTP Method: put
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/ivr-prompts/{promptId}
        ///     Rate Limit Group: Medium
        ///     App Permission: EditAccounts
        ///     User Permission: EditCompanyGreetings
        /// </summary>
        public async Task<PromptInfo> Put(UpdateIVRPromptRequest updateIVRPromptRequest,
            RestRequestConfig restRequestConfig = null)
        {
            if (promptId == null) throw new ArgumentException("Parameter cannot be null", nameof(promptId));
            return await rc.Put<PromptInfo>(Path(), updateIVRPromptRequest, null, restRequestConfig);
        }

        /// <summary>
        ///     Deletes an IVR prompt by ID.
        ///     HTTP Method: delete
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/ivr-prompts/{promptId}
        ///     Rate Limit Group: Heavy
        ///     App Permission: EditAccounts
        ///     User Permission: EditCompanyGreetings
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            if (promptId == null) throw new ArgumentException("Parameter cannot be null", nameof(promptId));
            return await rc.Delete<string>(Path(), null, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public IvrPrompts.Index IvrPrompts(string promptId = null)
        {
            return new IvrPrompts.Index(this, promptId);
        }
    }
}