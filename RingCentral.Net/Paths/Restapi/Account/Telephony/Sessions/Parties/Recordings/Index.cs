using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Parties.Recordings
{
    public class Index
    {
        public Parties.Index parent;
        public RestClient rc;
        public string recordingId;

        public Index(Parties.Index parent, string recordingId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.recordingId = recordingId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && recordingId != null) return $"{parent.Path()}/recordings/{recordingId}";
            return $"{parent.Path()}/recordings";
        }

        /// <summary>
        ///     Starts a new call recording for the party
        ///     HTTP Method: post
        ///     Endpoint:
        ///     /restapi/{apiVersion}/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/recordings
        ///     Rate Limit Group: Light
        ///     App Permission: CallControl
        /// </summary>
        public async Task<string> Post(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<string>(Path(false), null, restRequestConfig);
        }

        /// <summary>
        ///     Pause/resume recording
        ///     HTTP Method: patch
        ///     Endpoint:
        ///     /restapi/{apiVersion}/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/recordings/{recordingId}
        ///     Rate Limit Group: Light
        ///     App Permission: CallControl
        /// </summary>
        public async Task<RingCentral.CallRecording> Patch(CallRecordingUpdate callRecordingUpdate,
            PauseResumeCallRecordingParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            if (recordingId == null) throw new ArgumentException("Parameter cannot be null", nameof(recordingId));
            return await rc.Patch<RingCentral.CallRecording>(Path(), callRecordingUpdate, queryParams,
                restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Parties
{
    public partial class Index
    {
        public Recordings.Index Recordings(string recordingId = null)
        {
            return new Recordings.Index(this, recordingId);
        }
    }
}