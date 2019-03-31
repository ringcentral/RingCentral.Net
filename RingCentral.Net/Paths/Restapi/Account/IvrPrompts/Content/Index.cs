using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.IvrPrompts.Content
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.IvrPrompts.Index parent;

        public Index(Restapi.Account.IvrPrompts.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/content";
        }

        /// <summary>
        /// Operation: Get IVR Prompt Content
        /// Http Get /restapi/v1.0/account/{accountId}/ivr-prompts/{promptId}/content
        /// </summary>
        public async Task<string> Get()
        {
            return await rc.Get<string>(this.Path());
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.IvrPrompts
{
    public partial class Index
    {
        public Restapi.Account.IvrPrompts.Content.Index Content()
        {
            return new Restapi.Account.IvrPrompts.Content.Index(this);
        }
    }
}