using System.Threading.Tasks;

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

        // Operation: loadCallRecordingSettings
        public async Task<RingCentral.CallRecordingSettingsResource> Get()
        {
            return await rc.Get<RingCentral.CallRecordingSettingsResource>(this.Path());
        }

        // Operation: updateCallRecordingSettings
        public async Task<RingCentral.CallRecordingSettingsResource> Put(
            RingCentral.CallRecordingSettingsResource callRecordingSettingsResource)
        {
            return await rc.Put<RingCentral.CallRecordingSettingsResource>(this.Path(), callRecordingSettingsResource);
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