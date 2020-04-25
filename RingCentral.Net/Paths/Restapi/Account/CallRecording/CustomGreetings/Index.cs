using System.Threading.Tasks;
using System.Threading;

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

        /// <summary>
        /// Operation: Get Call Recording Custom Greeting List
        /// Rate Limit Group: Medium
        /// Http Get /restapi/v1.0/account/{accountId}/call-recording/custom-greetings
        /// </summary>
        public async Task<RingCentral.CallRecordingCustomGreetings> Get(
            ListCallRecordingCustomGreetingsParameters queryParams = null, CancellationToken? cancellationToken = null)
        {
            return await rc.Get<RingCentral.CallRecordingCustomGreetings>(this.Path(false), queryParams,
                cancellationToken);
        }

        /// <summary>
        /// Operation: Delete Call Recording Custom Greeting
        /// Rate Limit Group: Medium
        /// Http Delete /restapi/v1.0/account/{accountId}/call-recording/custom-greetings/{greetingId}
        /// </summary>
        public async Task<string> Delete(CancellationToken? cancellationToken = null)
        {
            if (this.greetingId == null)
            {
                throw new System.ArgumentNullException("greetingId");
            }

            return await rc.Delete<string>(this.Path(), null, cancellationToken);
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