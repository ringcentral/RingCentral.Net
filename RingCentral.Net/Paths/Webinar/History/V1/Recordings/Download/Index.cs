using System.Threading.Tasks;

namespace RingCentral.Paths.Webinar.History.V1.Recordings.Download
{
    public class Index
    {
        public Recordings.Index parent;
        public RestClient rc;

        public Index(Recordings.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/download";
        }

        /// <summary>
        ///     Returns the webinar recording download link (both Webinar host's and admin interface).
        ///     If called by a webinar host, the API returns error (403) if recording downloading is prohibited by company
        ///     settings.
        ///     The admin user who has "WebinarSettings" permission should be able to download recording regardless of current
        ///     company settings.
        ///     HTTP Method: get
        ///     Endpoint: /webinar/history/v1/recordings/{recordingId}/download
        ///     Rate Limit Group: Heavy
        ///     App Permission: ReadWebinars
        /// </summary>
        public async Task<RecordingDownloadModel> Get(
            RcwHistoryGetRecordingDownloadParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RecordingDownloadModel>(Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Webinar.History.V1.Recordings
{
    public partial class Index
    {
        public Download.Index Download()
        {
            return new Download.Index(this);
        }
    }
}