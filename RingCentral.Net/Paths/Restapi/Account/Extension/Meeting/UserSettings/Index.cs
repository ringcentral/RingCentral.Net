using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.Meeting.UserSettings
{
    public class Index
    {
        public Meeting.Index parent;
        public RestClient rc;

        public Index(Meeting.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/user-settings";
        }

        /// <summary>
        ///     Returns user settings for meetings.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/meeting/user-settings
        ///     Rate Limit Group: Light
        ///     App Permission: Meetings
        ///     User Permission: Meetings
        /// </summary>
        public async Task<MeetingUserSettingsResponse> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<MeetingUserSettingsResponse>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension.Meeting
{
    public partial class Index
    {
        public UserSettings.Index UserSettings()
        {
            return new UserSettings.Index(this);
        }
    }
}