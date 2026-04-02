using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.Extension.OverflowSettings
{
    public partial class Index
    {
        public RestClient rc;
public Restapi.Account.Extension.Index parent;
public Index(Restapi.Account.Extension.Index parent)
      {
this.parent = parent;
this.rc = parent.rc;
}
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/overflow-settings";
        }
        /// <summary>
        /// Returns overflow settings for a call queue specified in path.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{callQueueId}/overflow-settings
        /// Rate Limit Group: Heavy
        /// App Permission: ReadAccounts
        /// User Permission: CallQueueToCallQueue
        /// </summary>
  public async Task<RingCentral.CallQueueOverflowSettings> Get(RestRequestConfig restRequestConfig = null)
  {
return await rc.Get<RingCentral.CallQueueOverflowSettings>(this.Path(), null, restRequestConfig);
  }

        /// <summary>
        /// Updates overflow settings for a call queue specified in path.
        /// HTTP Method: put
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{callQueueId}/overflow-settings
        /// Rate Limit Group: Heavy
        /// App Permission: EditExtensions
        /// User Permission: CallQueueToCallQueue
        /// </summary>
  public async Task<RingCentral.CallQueueOverflowSettings> Put(RingCentral.CallQueueOverflowSettingsRequestResource callQueueOverflowSettingsRequestResource, RestRequestConfig restRequestConfig = null)
  {
return await rc.Put<RingCentral.CallQueueOverflowSettings>(this.Path(), callQueueOverflowSettingsRequestResource, null, restRequestConfig);
  }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.OverflowSettings.Index OverflowSettings()
        {
            return new Restapi.Account.Extension.OverflowSettings.Index(this);
        }
    }
}