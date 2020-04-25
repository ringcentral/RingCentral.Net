using System.Threading.Tasks;
using System.Threading;

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

        /// <summary>
        /// Operation: Create Recording
        /// Http Post /restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/recordings
        /// </summary>
        public async Task<string> Post(CancellationToken? cancellationToken = null)
        {
            return await rc.Post<string>(this.Path(false), null, cancellationToken);
        }

        /// <summary>
        /// Operation: Pause/Resume Recording
        /// Http Patch /restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/recordings/{recordingId}
        /// </summary>
        public async Task<RingCentral.CallRecording> Patch(RingCentral.CallRecordingUpdate callRecordingUpdate,
            PauseResumeCallRecordingParameters queryParams = null, CancellationToken? cancellationToken = null)
        {
            if (this.recordingId == null)
            {
                throw new System.ArgumentNullException("recordingId");
            }

            return await rc.Patch<RingCentral.CallRecording>(this.Path(), callRecordingUpdate, queryParams,
                cancellationToken);
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