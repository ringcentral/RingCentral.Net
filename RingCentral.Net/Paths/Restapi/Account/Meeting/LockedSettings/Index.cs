using System.Threading.Tasks;
using System.Threading;

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
        /// Operation: Get Locked Meeting Settings
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/meeting/locked-settings
        /// Rate Limit Group: Light
        /// App Permission: Meetings
        /// User Permission: Meetings
        /// </summary>
        public async Task<RingCentral.AccountLockedSettingResponse> Get(CancellationToken? cancellationToken = null)
        {
            return await rc.Get<RingCentral.AccountLockedSettingResponse>(this.Path(), null, cancellationToken);
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