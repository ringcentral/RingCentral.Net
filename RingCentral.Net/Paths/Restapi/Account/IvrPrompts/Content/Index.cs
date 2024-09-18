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
        ///     **This API must be called via media API entry point, e.g. https://media.ringcentral.com**
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/ivr-prompts/{promptId}/content
        ///     Rate Limit Group: Heavy
        ///     App Permission: ReadAccounts
        /// </summary>
        public async Task<byte[]> Get(ReadIVRPromptContentParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<byte[]>(Path(), queryParams, restRequestConfig);
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