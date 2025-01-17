using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Webinar.History.V1.Recordings
{
    public partial class Index
    {
        public V1.Index parent;
        public RestClient rc;
        public string recordingId;

        public Index(V1.Index parent, string recordingId = null)
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
        ///     Returns the list of webinar recordings for a given webinar host user
        ///     HTTP Method: get
        ///     Endpoint: /webinar/history/v1/recordings
        ///     Rate Limit Group: Heavy
        ///     App Permission: ReadWebinars
        /// </summary>
        public async Task<RecordingListResource> List(
            RcwHistoryListRecordingsParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RecordingListResource>(Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Returns the webinar recording by ID (Webinar host's interface).
        ///     This API also returns sharing link if sharing is enabled.
        ///     HTTP Method: get
        ///     Endpoint: /webinar/history/v1/recordings/{recordingId}
        ///     Rate Limit Group: Heavy
        ///     App Permission: ReadWebinars
        /// </summary>
        public async Task<RecordingItemExtendedModel> Get(RestRequestConfig restRequestConfig = null)
        {
            if (recordingId == null) throw new ArgumentException("Parameter cannot be null", nameof(recordingId));

            return await rc.Get<RecordingItemExtendedModel>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Webinar.History.V1
{
    public partial class Index
    {
        public Recordings.Index Recordings(string recordingId = null)
        {
            return new Recordings.Index(this, recordingId);
        }
    }
}