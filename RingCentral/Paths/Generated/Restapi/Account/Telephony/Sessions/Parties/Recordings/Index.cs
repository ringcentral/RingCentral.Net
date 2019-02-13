using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Parties.Recordings
{
    public partial class Index
    {
        public RestClient rc;
        public string recordingId;
        public Restapi.Account.Telephony.Sessions.Parties.Index parent;

        public Index(Restapi.Account.Telephony.Sessions.Parties.Index parent, string recordingId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.recordingId = recordingId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && recordingId != null)
            {
                return $"{parent.Path()}/recordings/{recordingId}";
            }

            return $"{parent.Path()}/recordings";
        }

        public async Task<string> Post()
        {
            return await rc.Post<string>(this.Path(false));
        }

        public async Task<RingCentral.CallRecording> Patch(RingCentral.CallRecordingUpdate callRecordingUpdate,
            PatchQueryParams queryParams = null)
        {
            if (this.recordingId == null)
            {
                throw new System.ArgumentNullException("recordingId");
            }

            return await rc.Patch<RingCentral.CallRecording>(this.Path(), callRecordingUpdate, queryParams);
        }

        public async Task<RingCentral.CallRecording> Patch(object callRecordingUpdate, object queryParams)
        {
            if (this.recordingId == null)
            {
                throw new System.ArgumentNullException("recordingId");
            }

            return await rc.Patch<RingCentral.CallRecording>(this.Path(), callRecordingUpdate, queryParams);
        }
    }

    public class PatchQueryParams
    {
        // Identifies a brand of a logged in user or a brand of a sign-up session
        public string brandId; // Required
    }
}

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Parties
{
    public partial class Index
    {
        public Restapi.Account.Telephony.Sessions.Parties.Recordings.Index Recordings(string recordingId = null)
        {
            return new Restapi.Account.Telephony.Sessions.Parties.Recordings.Index(this, recordingId);
        }
    }
}