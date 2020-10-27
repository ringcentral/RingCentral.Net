using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.CallerBlocking
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
            return $"{parent.Path()}/caller-blocking";
        }

        /// <summary>
        /// Operation: Get Caller Blocking Settings
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// User Permission: ReadBlockedNumbers
        /// </summary>
        public async Task<RingCentral.CallerBlockingSettings> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.CallerBlockingSettings>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Operation: Update Caller Blocking Settings
        /// HTTP Method: PUT
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking
        /// Rate Limit Group: Light
        /// App Permission: EditExtensions
        /// User Permission: EditBlockedNumbers
        /// </summary>
        public async Task<RingCentral.CallerBlockingSettings> Put(
            RingCentral.CallerBlockingSettingsUpdate callerBlockingSettingsUpdate,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Put<RingCentral.CallerBlockingSettings>(this.Path(), callerBlockingSettingsUpdate, null,
                restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.CallerBlocking.Index CallerBlocking()
        {
            return new Restapi.Account.Extension.CallerBlocking.Index(this);
        }
    }
}