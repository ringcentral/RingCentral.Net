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

        // Operation: Starts new call recording in a party
        // Http Post /restapi/v1.0/account/{accountId}/telephony/sessions/{sessionId}/parties/{partyId}/recordings
        public async Task<string> Post()
        {
            return await rc.Post<string>(this.Path(false));
        }

        // Operation: Pause/Resume Recording
        // Http Patch /restapi/v1.0/account/{accountId}/telephony/sessions/{sessionId}/parties/{partyId}/recordings/{recordingId}
        public async Task<RingCentral.CallRecording> Patch(RingCentral.CallRecordingUpdate callRecordingUpdate,
            PauseResumeCallRecordingParameters queryParams = null)
        {
            if (this.recordingId == null)
            {
                throw new System.ArgumentNullException("recordingId");
            }

            return await rc.Patch<RingCentral.CallRecording>(this.Path(), callRecordingUpdate, queryParams);
        }
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