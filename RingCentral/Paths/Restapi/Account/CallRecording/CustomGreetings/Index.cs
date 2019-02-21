using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.CallRecording.CustomGreetings
{
    public partial class Index
    {
        public RestClient rc;
        public string greetingId;
        public Restapi.Account.CallRecording.Index parent;

        public Index(Restapi.Account.CallRecording.Index parent, string greetingId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.greetingId = greetingId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && greetingId != null)
            {
                return $"{parent.Path()}/custom-greetings/{greetingId}";
            }

            return $"{parent.Path()}/custom-greetings";
        }

        public async Task<RingCentral.CallRecordingCustomGreetings> Get(
            ListCallRecordingCustomGreetingsParameters queryParams = null)
        {
            return await rc.Get<RingCentral.CallRecordingCustomGreetings>(this.Path(false), queryParams);
        }

        public async Task<string> Delete()
        {
            if (this.greetingId == null)
            {
                throw new System.ArgumentNullException("greetingId");
            }

            return await rc.Delete<string>(this.Path());
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.CallRecording
{
    public partial class Index
    {
        public Restapi.Account.CallRecording.CustomGreetings.Index CustomGreetings(string greetingId = null)
        {
            return new Restapi.Account.CallRecording.CustomGreetings.Index(this, greetingId);
        }
    }
}