using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.Extension.Greeting.HoldMusic
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Extension.Greeting.Index parent;
        public Index(Restapi.Account.Extension.Greeting.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/hold-music";
        }
        /// <summary>
        /// Returns a custom hold music greeting for user.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/greeting/hold-music
        /// Rate Limit Group: Medium
        /// App Permission: ReadAccounts
        /// User Permission: ReadUserInfo
        /// </summary>
        public async Task<RingCentral.CustomUserGreetingInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.CustomUserGreetingInfo>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension.Greeting
{
    public partial class Index
    {
        public Restapi.Account.Extension.Greeting.HoldMusic.Index HoldMusic()
        {
            return new Restapi.Account.Extension.Greeting.HoldMusic.Index(this);
        }
    }
}