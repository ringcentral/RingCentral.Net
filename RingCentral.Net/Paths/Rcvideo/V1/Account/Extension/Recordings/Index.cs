using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Rcvideo.V1.Account.Extension.Recordings
{
    public partial class Index
    {
        public RestClient rc;
        public Rcvideo.V1.Account.Extension.Index parent;
        public Index(Rcvideo.V1.Account.Extension.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/recordings";
        }
        /// <summary>
        /// Returns all recordings owned by a specific extension.
        /// 
        /// HTTP Method: get
        /// Endpoint: /rcvideo/v1/account/{accountId}/extension/{extensionId}/recordings
        /// Rate Limit Group: Light
        /// App Permission: Video
        /// </summary>
        public async Task<RingCentral.CloudRecordings> Get(RingCentral.GetExtensionRecordingsParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.CloudRecordings>(this.Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Rcvideo.V1.Account.Extension
{
    public partial class Index
    {
        public Rcvideo.V1.Account.Extension.Recordings.Index Recordings()
        {
            return new Rcvideo.V1.Account.Extension.Recordings.Index(this);
        }
    }
}