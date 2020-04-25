using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Account.IvrPrompts
{
    public partial class Index
    {
        public RestClient rc;
        public string promptId;
        public Restapi.Account.Index parent;

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
        /// Operation: Create IVR Prompts
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/account/{accountId}/ivr-prompts
        /// Rate Limit Group: Heavy
        /// App Permission Required: EditAccounts
        /// User Permission Required: EditCompanyGreetings
        /// </summary>
        public async Task<RingCentral.PromptInfo> Post(CreateIvrPromptRequest createIVRPromptRequest,
            CancellationToken? cancellationToken = null)
        {
            var multipartFormDataContent = Utils.GetMultipartFormDataContent(createIVRPromptRequest);
            return await rc.Post<RingCentral.PromptInfo>(this.Path(false), multipartFormDataContent, null,
                cancellationToken);
        }

        /// <summary>
        /// Operation: Get IVR Prompt List
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/ivr-prompts
        /// Rate Limit Group: Medium
        /// App Permission Required: ReadAccounts
        /// User Permission Required: ReadCompanyGreetings
        /// </summary>
        public async Task<RingCentral.IVRPrompts> List(CancellationToken? cancellationToken = null)
        {
            return await rc.Get<RingCentral.IVRPrompts>(this.Path(false), null, cancellationToken);
        }

        /// <summary>
        /// Operation: Get IVR Prompt
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/ivr-prompts/{promptId}
        /// Rate Limit Group: Medium
        /// App Permission Required: ReadAccounts
        /// User Permission Required: ReadCompanyGreetings
        /// </summary>
        public async Task<RingCentral.PromptInfo> Get(CancellationToken? cancellationToken = null)
        {
            if (this.promptId == null)
            {
                throw new System.ArgumentNullException("promptId");
            }

            return await rc.Get<RingCentral.PromptInfo>(this.Path(), null, cancellationToken);
        }

        /// <summary>
        /// Operation: Delete IVR Prompt
        /// HTTP Method: DELETE
        /// Endpoint: /restapi/v1.0/account/{accountId}/ivr-prompts/{promptId}
        /// Rate Limit Group: Heavy
        /// App Permission Required: EditAccounts
        /// User Permission Required: EditCompanyGreetings
        /// </summary>
        public async Task<string> Delete(CancellationToken? cancellationToken = null)
        {
            if (this.promptId == null)
            {
                throw new System.ArgumentNullException("promptId");
            }

            return await rc.Delete<string>(this.Path(), null, cancellationToken);
        }

        /// <summary>
        /// Operation: Update IVR Prompt
        /// HTTP Method: PUT
        /// Endpoint: /restapi/v1.0/account/{accountId}/ivr-prompts/{promptId}
        /// Rate Limit Group: Medium
        /// App Permission Required: EditAccounts
        /// User Permission Required: EditCompanyGreetings
        /// </summary>
        public async Task<RingCentral.PromptInfo> Put(RingCentral.UpdateIVRPromptRequest updateIVRPromptRequest,
            CancellationToken? cancellationToken = null)
        {
            if (this.promptId == null)
            {
                throw new System.ArgumentNullException("promptId");
            }

            return await rc.Put<RingCentral.PromptInfo>(this.Path(), updateIVRPromptRequest, null, cancellationToken);
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