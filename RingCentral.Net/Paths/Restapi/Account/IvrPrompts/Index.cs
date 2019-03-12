using System.Threading.Tasks;

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

        // Operation: Create IVR Prompts
        // Http Post /restapi/v1.0/account/{accountId}/ivr-prompts
        public async Task<RingCentral.PromptInfo> Post(CreateIvrPromptRequest createIvrPromptRequest)
        {
            var multipartFormDataContent = Utils.GetMultipartFormDataContent(createIvrPromptRequest);
            return await rc.Post<RingCentral.PromptInfo>(this.Path(false), multipartFormDataContent);
        }

        // Operation: Get IVR Prompts
        // Http Get /restapi/v1.0/account/{accountId}/ivr-prompts
        public async Task<RingCentral.IVRPrompts> List()
        {
            return await rc.Get<RingCentral.IVRPrompts>(this.Path(false));
        }

        // Operation: Get IVR Prompt
        // Http Get /restapi/v1.0/account/{accountId}/ivr-prompts/{promptId}
        public async Task<RingCentral.PromptInfo> Get()
        {
            if (this.promptId == null)
            {
                throw new System.ArgumentNullException("promptId");
            }

            return await rc.Get<RingCentral.PromptInfo>(this.Path());
        }

        // Operation: Delete IVR Prompt
        // Http Delete /restapi/v1.0/account/{accountId}/ivr-prompts/{promptId}
        public async Task<string> Delete()
        {
            if (this.promptId == null)
            {
                throw new System.ArgumentNullException("promptId");
            }

            return await rc.Delete<string>(this.Path());
        }

        // Operation: Update IVR Prompt
        // Http Put /restapi/v1.0/account/{accountId}/ivr-prompts/{promptId}
        public async Task<string> Put()
        {
            if (this.promptId == null)
            {
                throw new System.ArgumentNullException("promptId");
            }

            return await rc.Put<string>(this.Path());
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