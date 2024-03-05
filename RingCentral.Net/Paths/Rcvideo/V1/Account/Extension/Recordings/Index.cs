using System.Threading.Tasks;

namespace RingCentral.Paths.Rcvideo.V1.Account.Extension.Recordings
{
    public class Index
    {
        public Extension.Index parent;
        public RestClient rc;

        public Index(Extension.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/recordings";
        }

        /// <summary>
        ///     Returns all recordings available for specific extension.
        ///     This endpoint is used in admin recording service, not regular web
        ///     HTTP Method: get
        ///     Endpoint: /rcvideo/v1/account/{accountId}/extension/{extensionId}/recordings
        ///     Rate Limit Group: Light
        ///     App Permission: Video
        /// </summary>
        public async Task<CloudRecordings> Get(GetExtensionRecordingsParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<CloudRecordings>(Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Rcvideo.V1.Account.Extension
{
    public partial class Index
    {
        public Recordings.Index Recordings()
        {
            return new Recordings.Index(this);
        }
    }
}