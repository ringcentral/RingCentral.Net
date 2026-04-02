using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.Recording.Content
{
    public partial class Index
    {
        public RestClient rc;
public Restapi.Account.Recording.Index parent;
public Index(Restapi.Account.Recording.Index parent)
      {
this.parent = parent;
this.rc = parent.rc;
}
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/content";
        }
        /// <summary>
        /// Returns media content of a call recording (`audio/mpeg` or `audio/wav`)
/// 
/// **This API must be called via media API entry point, e.g. https://media.ringcentral.com**
/// 
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/recording/{recordingId}/content
        /// Rate Limit Group: Heavy
        /// App Permission: ReadCallRecording
        /// </summary>
  public async Task<byte[]> Get(RingCentral.ReadCallRecordingContentParameters queryParams = null, RestRequestConfig restRequestConfig = null)
  {
return await rc.Get<byte[]>(this.Path(), queryParams, restRequestConfig);
  }
    }
}

namespace RingCentral.Paths.Restapi.Account.Recording
{
    public partial class Index
    {
        public Restapi.Account.Recording.Content.Index Content()
        {
            return new Restapi.Account.Recording.Content.Index(this);
        }
    }
}