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

        public async Task<RingCentral.PromptInfo> Post()
        {
            return await rc.Post<RingCentral.PromptInfo>(this.Path(false));
        }

        public async Task<RingCentral.IVRPrompts> List()
        {
            return await rc.Get<RingCentral.IVRPrompts>(this.Path(false));
        }

        public async Task<RingCentral.PromptInfo> Get()
        {
            if (this.promptId == null)
            {
                throw new System.ArgumentNullException("promptId");
            }

            return await rc.Get<RingCentral.PromptInfo>(this.Path());
        }

        public async Task<string> Delete()
        {
            if (this.promptId == null)
            {
                throw new System.ArgumentNullException("promptId");
            }

            return await rc.Delete<string>(this.Path());
        }

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