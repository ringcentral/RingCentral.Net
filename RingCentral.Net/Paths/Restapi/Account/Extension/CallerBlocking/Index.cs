using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.CallerBlocking
{
    public partial class Index
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
            return $"{parent.Path()}/caller-blocking";
        }

        /// <summary>
        ///     Returns the current caller blocking settings of a user.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/caller-blocking
        ///     Rate Limit Group: Light
        ///     App Permission: ReadAccounts
        ///     User Permission: ReadBlockedNumbers
        /// </summary>
        public async Task<CallerBlockingSettings> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<CallerBlockingSettings>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Updates the current caller blocking settings of a user.
        ///     HTTP Method: put
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/caller-blocking
        ///     Rate Limit Group: Light
        ///     App Permission: EditExtensions
        ///     User Permission: EditBlockedNumbers
        /// </summary>
        public async Task<CallerBlockingSettings> Put(
            CallerBlockingSettingsUpdate callerBlockingSettingsUpdate,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Put<CallerBlockingSettings>(Path(), callerBlockingSettingsUpdate, null,
                restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public CallerBlocking.Index CallerBlocking()
        {
            return new CallerBlocking.Index(this);
        }
    }
}