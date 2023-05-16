using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.IvrPrompts.Content
{
    public class Index
    {
        public IvrPrompts.Index parent;
        public RestClient rc;

        public Index(IvrPrompts.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/content";
        }

        /// <summary>
        ///     Returns media content of an IVR prompt by ID.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/ivr-prompts/{promptId}/content
        ///     Rate Limit Group: Medium
        ///     App Permission: ReadAccounts
        ///     User Permission: ReadCompanyGreetings
        /// </summary>
        public async Task<byte[]> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<byte[]>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.IvrPrompts
{
    public partial class Index
    {
        public Content.Index Content()
        {
            return new Content.Index(this);
        }
    }
}