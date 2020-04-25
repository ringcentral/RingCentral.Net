using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Account.CallRecording.Extensions
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.CallRecording.Index parent;

        public Index(Restapi.Account.CallRecording.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/extensions";
        }

        /// <summary>
        /// Operation: Get Call Recording Extension List
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/call-recording/extensions
        /// Rate Limit Group: Medium
        /// App Permission Required: ReadAccounts
        /// User Permission Required: ReadCompanyInfo
        /// </summary>
        public async Task<RingCentral.CallRecordingExtensions> Get(CancellationToken? cancellationToken = null)
        {
            return await rc.Get<RingCentral.CallRecordingExtensions>(this.Path(), null, cancellationToken);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.CallRecording
{
    public partial class Index
    {
        public Restapi.Account.CallRecording.Extensions.Index Extensions()
        {
            return new Restapi.Account.CallRecording.Extensions.Index(this);
        }
    }
}