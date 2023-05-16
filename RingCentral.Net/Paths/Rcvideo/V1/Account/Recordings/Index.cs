using System.Threading.Tasks;

namespace RingCentral.Paths.Rcvideo.V1.Account.Recordings
{
    public class Index
    {
        public Account.Index parent;
        public RestClient rc;

        public Index(Account.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/recordings";
        }

        /// <summary>
        ///     Returns the list of meeting recordings belonging to all account users.
        ///     HTTP Method: get
        ///     Endpoint: /rcvideo/v1/account/{accountId}/recordings
        ///     Rate Limit Group: Light
        ///     App Permission: Video
        /// </summary>
        public async Task<CloudRecordings> Get(GetAccountRecordingsParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<CloudRecordings>(Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Rcvideo.V1.Account
{
    public partial class Index
    {
        public Recordings.Index Recordings()
        {
            return new Recordings.Index(this);
        }
    }
}