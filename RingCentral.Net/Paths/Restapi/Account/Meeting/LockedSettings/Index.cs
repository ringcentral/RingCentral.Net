using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Meeting.LockedSettings
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
            return $"{parent.Path()}/locked-settings";
        }

        /// <summary>
        ///     Returns information on user meeting settings that are locked on account level and therefore cannot be changed by
        ///     user.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/meeting/locked-settings
        ///     Rate Limit Group: Light
        ///     App Permission: Meetings
        ///     User Permission: Meetings
        /// </summary>
        public async Task<AccountLockedSettingResponse> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<AccountLockedSettingResponse>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Meeting
{
    public partial class Index
    {
        public LockedSettings.Index LockedSettings()
        {
            return new LockedSettings.Index(this);
        }
    }
}