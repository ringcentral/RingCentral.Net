using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Account.Extension.Meeting.UserSettings
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Extension.Meeting.Index parent;

        public Index(Restapi.Account.Extension.Meeting.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/user-settings";
        }

        /// <summary>
        /// Operation: Get Meeting User Settings
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting/user-settings
        /// Rate Limit Group: Light
        /// App Permission: Meetings
        /// User Permission: Meetings
        /// </summary>
        public async Task<RingCentral.MeetingUserSettingsResponse> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.MeetingUserSettingsResponse>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension.Meeting
{
    public partial class Index
    {
        public Restapi.Account.Extension.Meeting.UserSettings.Index UserSettings()
        {
            return new Restapi.Account.Extension.Meeting.UserSettings.Index(this);
        }
    }
}