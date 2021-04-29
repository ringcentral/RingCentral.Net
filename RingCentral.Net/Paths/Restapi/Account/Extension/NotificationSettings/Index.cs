using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

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

        /// <summary>
        /// Returns notification settings for the current extension.
        ///  <p>Knowledge Article: <a href="https://success.ringcentral.com/articles/RC_Knowledge_Article/9740">User Settings - Set up Message Notifications</a></p>
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/notification-settings
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// User Permission: ReadMessagesNotificationsSettings
        /// </summary>
        public async Task<RingCentral.NotificationSettings> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.NotificationSettings>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Updates notification settings for the current extension.
        /// <p>Knowledge Article: <a href="https://success.ringcentral.com/articles/RC_Knowledge_Article/9740">User Settings - Set up Message Notifications</a></p>
        /// HTTP Method: put
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/notification-settings
        /// Rate Limit Group: Medium
        /// App Permission: EditExtensions
        /// User Permission: EditMessagesNotificationsSettings
        /// </summary>
        public async Task<RingCentral.NotificationSettings> Put(
            RingCentral.NotificationSettingsUpdateRequest notificationSettingsUpdateRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Put<RingCentral.NotificationSettings>(this.Path(), notificationSettingsUpdateRequest, null,
                restRequestConfig);
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