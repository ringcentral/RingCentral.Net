using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Account.CallRecording
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Index parent;

        public Index(Restapi.Account.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/call-recording";
        }

        /// <summary>
        /// Operation: Get Call Recording Settings
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/call-recording
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// User Permission: ReadCompanyInfo
        /// </summary>
        public async Task<RingCentral.CallRecordingSettingsResource> Get(CancellationToken? cancellationToken = null)
        {
            return await rc.Get<RingCentral.CallRecordingSettingsResource>(this.Path(), null, cancellationToken);
        }

        /// <summary>
        /// Operation: Update Call Recording Settings
        /// HTTP Method: PUT
        /// Endpoint: /restapi/v1.0/account/{accountId}/call-recording
        /// Rate Limit Group: Medium
        /// App Permission: EditAccounts
        /// User Permission: EditCompanyInfo
        /// </summary>
        public async Task<RingCentral.CallRecordingSettingsResource> Put(
            RingCentral.CallRecordingSettingsResource callRecordingSettingsResource,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Put<RingCentral.CallRecordingSettingsResource>(this.Path(), callRecordingSettingsResource,
                null, cancellationToken);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public Restapi.Account.CallRecording.Index CallRecording()
        {
            return new Restapi.Account.CallRecording.Index(this);
        }
    }
}