using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Greeting.Content
{
    public class Index
    {
        public Greeting.Index parent;
        public RestClient rc;

        public Index(Greeting.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/content";
        }

        /// <summary>
        ///     Returns account-level greeting media contents.
        ///     **This API must be called via media API entry point, e.g. https://media.ringcentral.com**
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/greeting/{greetingId}/content
        ///     Rate Limit Group: Heavy
        ///     App Permission: ReadAccounts
        /// </summary>
        public async Task<byte[]> Get(ReadAccountGreetingContentParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<byte[]>(Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Greeting
{
    public partial class Index
    {
        public Content.Index Content()
        {
            return new Content.Index(this);
        }
    }
}