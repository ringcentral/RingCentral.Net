using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.Meeting.LockedSettings
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Meeting.Index parent;

        public Index(Restapi.Account.Meeting.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/locked-settings";
        }

        /// <summary>
        /// Returns information on user meeting settings that are locked on account level and therefore cannot be changed by user.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/meeting/locked-settings
        /// Rate Limit Group: Light
        /// App Permission: Meetings
        /// User Permission: Meetings
        /// </summary>
        public async Task<RingCentral.AccountLockedSettingResponse> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.AccountLockedSettingResponse>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Meeting
{
    public partial class Index
    {
        public Restapi.Account.Meeting.LockedSettings.Index LockedSettings()
        {
            return new Restapi.Account.Meeting.LockedSettings.Index(this);
        }
    }
}