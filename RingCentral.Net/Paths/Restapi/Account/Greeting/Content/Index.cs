using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.Greeting.Content
{
    public partial class Index
    {
        public RestClient rc;
public Restapi.Account.Greeting.Index parent;
public Index(Restapi.Account.Greeting.Index parent)
      {
this.parent = parent;
this.rc = parent.rc;
}
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/content";
        }
        /// <summary>
        /// Returns account-level greeting media contents.
/// 
/// **This API must be called via media API entry point, e.g. https://media.ringcentral.com**
/// 
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/greeting/{greetingId}/content
        /// Rate Limit Group: Heavy
        /// App Permission: ReadAccounts
        /// </summary>
  public async Task<byte[]> Get(RingCentral.ReadAccountGreetingContentParameters queryParams = null, RestRequestConfig restRequestConfig = null)
  {
return await rc.Get<byte[]>(this.Path(), queryParams, restRequestConfig);
  }
    }
}

namespace RingCentral.Paths.Restapi.Account.Greeting
{
    public partial class Index
    {
        public Restapi.Account.Greeting.Content.Index Content()
        {
            return new Restapi.Account.Greeting.Content.Index(this);
        }
    }
}