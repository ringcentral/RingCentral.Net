using System.Threading.Tasks;
using System.Threading;

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
        /// Rate Limit Group: Light
        /// Http Get /restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking
        /// </summary>
        public async Task<RingCentral.CallerBlockingSettings> Get(CancellationToken? cancellationToken = null)
        {
            return await rc.Get<RingCentral.CallerBlockingSettings>(this.Path(), null, cancellationToken);
        }

        /// <summary>
        /// Operation: Update Caller Blocking Settings
        /// Rate Limit Group: Light
        /// Http Put /restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking
        /// </summary>
        public async Task<RingCentral.CallerBlockingSettings> Put(
            RingCentral.CallerBlockingSettingsUpdate callerBlockingSettingsUpdate,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Put<RingCentral.CallerBlockingSettings>(this.Path(), callerBlockingSettingsUpdate, null,
                cancellationToken);
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