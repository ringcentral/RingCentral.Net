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
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/ivr-prompts/{promptId}/content
        /// Rate Limit Group: Medium
        /// App Permission: ReadAccounts
        /// User Permission: ReadCompanyGreetings
        /// </summary>
        public async Task<byte[]> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<byte[]>(this.Path(), null, restRequestConfig);
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