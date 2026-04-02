using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

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
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/content";
        }
        /// <summary>
        /// Returns media content of an IVR prompt by ID.
/// 
/// **This API must be called via media API entry point, e.g. https://media.ringcentral.com**
/// 
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/ivr-prompts/{promptId}/content
        /// Rate Limit Group: Heavy
        /// App Permission: ReadAccounts
        /// </summary>
  public async Task<byte[]> Get(RingCentral.ReadIVRPromptContentParameters queryParams = null, RestRequestConfig restRequestConfig = null)
  {
return await rc.Get<byte[]>(this.Path(), queryParams, restRequestConfig);
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