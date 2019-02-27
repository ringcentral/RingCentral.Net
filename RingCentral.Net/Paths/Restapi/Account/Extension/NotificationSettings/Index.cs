using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.NotificationSettings
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

        public string Path()
        {
            return $"{parent.Path()}/notification-settings";
        }

        // Operation: loadNotificationSettings
        // Http Get /restapi/v1.0/account/{accountId}/extension/{extensionId}/notification-settings
        public async Task<RingCentral.NotificationSettings> Get()
        {
            return await rc.Get<RingCentral.NotificationSettings>(this.Path());
        }

        // Operation: updateNotificationSettings
        // Http Put /restapi/v1.0/account/{accountId}/extension/{extensionId}/notification-settings
        public async Task<RingCentral.NotificationSettings> Put(
            RingCentral.NotificationSettingsUpdateRequest notificationSettingsUpdateRequest)
        {
            return await rc.Put<RingCentral.NotificationSettings>(this.Path(), notificationSettingsUpdateRequest);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.NotificationSettings.Index NotificationSettings()
        {
            return new Restapi.Account.Extension.NotificationSettings.Index(this);
        }
    }
}