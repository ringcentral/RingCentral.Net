using System.Threading.Tasks;

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

        // Operation: listCallRecordingExtensionSettings
        public async Task<string> Get()
        {
            return await rc.Get<string>(this.Path());
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