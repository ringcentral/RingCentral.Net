using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.OverflowSettings
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

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/overflow-settings";
        }

        /// <summary>
        ///     Returns overflow settings for a call queue specified in path.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{callQueueId}/overflow-settings
        ///     Rate Limit Group: Heavy
        ///     App Permission: ReadAccounts
        ///     User Permission: CallQueueToCallQueue
        /// </summary>
        public async Task<CallQueueOverflowSettings> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<CallQueueOverflowSettings>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Updates overflow settings for a call queue specified in path.
        ///     HTTP Method: put
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{callQueueId}/overflow-settings
        ///     Rate Limit Group: Heavy
        ///     App Permission: EditExtensions
        ///     User Permission: CallQueueToCallQueue
        /// </summary>
        public async Task<CallQueueOverflowSettings> Put(
            CallQueueOverflowSettingsRequestResource callQueueOverflowSettingsRequestResource,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Put<CallQueueOverflowSettings>(Path(),
                callQueueOverflowSettingsRequestResource, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public OverflowSettings.Index OverflowSettings()
        {
            return new OverflowSettings.Index(this);
        }
    }
}