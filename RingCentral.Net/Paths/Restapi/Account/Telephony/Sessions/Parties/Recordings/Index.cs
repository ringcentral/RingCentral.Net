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

        /// <summary>
        /// Starts a new call recording for the party
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/recordings
        /// Rate Limit Group: Light
        /// App Permission: CallControl
        /// User Permission: undefined
        /// </summary>
        public async Task<string> Post(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<string>(this.Path(false), null, restRequestConfig);
        }

        /// <summary>
        /// Pause/resume recording
        /// HTTP Method: PATCH
        /// Endpoint: /restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/recordings/{recordingId}
        /// Rate Limit Group: Light
        /// App Permission: CallControl
        /// User Permission: undefined
        /// </summary>
        public async Task<RingCentral.CallRecording> Patch(RingCentral.CallRecordingUpdate callRecordingUpdate,
            PauseResumeCallRecordingParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            if (this.recordingId == null)
            {
                throw new System.ArgumentNullException("recordingId");
            }

            return await rc.Patch<RingCentral.CallRecording>(this.Path(), callRecordingUpdate, queryParams,
                restRequestConfig);
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