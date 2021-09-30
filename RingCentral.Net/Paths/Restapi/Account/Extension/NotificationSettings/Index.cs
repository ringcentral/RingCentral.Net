using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.NotificationSettings
{
    public class Index
    {
        public Extension.Index parent;
        public RestClient rc;

        public Index(Extension.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/notification-settings";
        }

        /// <summary>
        ///     Returns notification settings for the current extension.
        ///     <p>
        ///         Knowledge Article:
        ///         <a href="https://success.ringcentral.com/articles/RC_Knowledge_Article/9740">
        ///             User Settings - Set up Message
        ///             Notifications
        ///         </a>
        ///     </p>
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/notification-settings
        ///     Rate Limit Group: Light
        ///     App Permission: ReadAccounts
        ///     User Permission: ReadMessagesNotificationsSettings
        /// </summary>
        public async Task<RingCentral.NotificationSettings> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.NotificationSettings>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Updates notification settings for the current extension.
        ///     <p>
        ///         Knowledge Article:
        ///         <a href="https://success.ringcentral.com/articles/RC_Knowledge_Article/9740">
        ///             User Settings - Set up Message
        ///             Notifications
        ///         </a>
        ///     </p>
        ///     HTTP Method: put
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/notification-settings
        ///     Rate Limit Group: Medium
        ///     App Permission: EditExtensions
        ///     User Permission: EditMessagesNotificationsSettings
        /// </summary>
        public async Task<RingCentral.NotificationSettings> Put(
            NotificationSettingsUpdateRequest notificationSettingsUpdateRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Put<RingCentral.NotificationSettings>(Path(), notificationSettingsUpdateRequest, null,
                restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public NotificationSettings.Index NotificationSettings()
        {
            return new NotificationSettings.Index(this);
        }
    }
}