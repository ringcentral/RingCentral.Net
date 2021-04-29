using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.Recording
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Index parent;
        public string recordingId;

        public Index(Restapi.Account.Index parent, string recordingId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.recordingId = recordingId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && recordingId != null)
            {
                return $"{parent.Path()}/recording/{recordingId}";
            }

            return $"{parent.Path()}/recording";
        }

        /// <summary>
        /// Returns call recordings by ID(s).
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/recording/{recordingId}
        /// Rate Limit Group: Heavy
        /// App Permission: ReadCallRecording
        /// User Permission: ReadCallRecording
        /// </summary>
        public async Task<RingCentral.GetCallRecordingResponse> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.GetCallRecordingResponse>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public Restapi.Account.Recording.Index Recording(string recordingId = null)
        {
            return new Restapi.Account.Recording.Index(this, recordingId);
        }
    }
}