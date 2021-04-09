using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Recording
{
    public partial class Index
    {
        public Account.Index parent;
        public RestClient rc;
        public string recordingId;

        public Index(Account.Index parent, string recordingId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.recordingId = recordingId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && recordingId != null) return $"{parent.Path()}/recording/{recordingId}";
            return $"{parent.Path()}/recording";
        }

        /// <summary>
        ///     Returns call recordings by ID(s).
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/recording/{recordingId}
        ///     Rate Limit Group: Heavy
        ///     App Permission: ReadCallRecording
        ///     User Permission: ReadCallRecording
        /// </summary>
        public async Task<GetCallRecordingResponse> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<GetCallRecordingResponse>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public Recording.Index Recording(string recordingId = null)
        {
            return new Recording.Index(this, recordingId);
        }
    }
}