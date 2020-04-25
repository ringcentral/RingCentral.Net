using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Account.Recording.Content
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Recording.Index parent;

        public Index(Restapi.Account.Recording.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/content";
        }

        /// <summary>
        /// Operation: Get Call Recordings Data
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/recording/{recordingId}/content
        /// Rate Limit Group: Heavy
        /// App Permission: ReadCallRecording
        /// User Permission: ReadCallRecording
        /// </summary>
        public async Task<byte[]> Get(CancellationToken? cancellationToken = null)
        {
            return await rc.Get<byte[]>(this.Path(), null, cancellationToken);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Recording
{
    public partial class Index
    {
        public Restapi.Account.Recording.Content.Index Content()
        {
            return new Restapi.Account.Recording.Content.Index(this);
        }
    }
}