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
        /// Rate Limit Group: Light
        /// Http Get /restapi/v1.0/account/{accountId}/call-recording
        /// </summary>
        public async Task<RingCentral.CallRecordingSettingsResource> Get(CancellationToken? cancellationToken = null)
        {
            return await rc.Get<RingCentral.CallRecordingSettingsResource>(this.Path(), null, cancellationToken);
        }

        /// <summary>
        /// Operation: Update Call Recording Settings
        /// Rate Limit Group: Medium
        /// Http Put /restapi/v1.0/account/{accountId}/call-recording
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