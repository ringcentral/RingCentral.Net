using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Webinar.History.V1.Company.Recordings
{
    public class Index
    {
        public Company.Index parent;
        public RestClient rc;
        public string recordingId;

        public Index(Company.Index parent, string recordingId = null)
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
        ///     Returns the list of webinar recordings (Administrator's interface).
        ///     The user must have "WebinarSettings" permission granted otherwise the API returns HTTP 403.
        ///     HTTP Method: get
        ///     Endpoint: /webinar/history/v1/company/recordings
        ///     Rate Limit Group: Heavy
        ///     App Permission: ReadWebinars
        /// </summary>
        public async Task<RecordingAdminListResource> List(RcwHistoryAdminListRecordingsParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RecordingAdminListResource>(Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Returns the webinar recording by ID (Administrator's interface).
        ///     The user must have "WebinarSettings" permission granted otherwise the API returns HTTP 403.
        ///     HTTP Method: get
        ///     Endpoint: /webinar/history/v1/company/recordings/{recordingId}
        ///     Rate Limit Group: Heavy
        ///     App Permission: ReadWebinars
        /// </summary>
        public async Task<RecordingAdminExtendedItemModel> Get(RestRequestConfig restRequestConfig = null)
        {
            if (recordingId == null) throw new ArgumentException("Parameter cannot be null", nameof(recordingId));
            return await rc.Get<RecordingAdminExtendedItemModel>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Webinar.History.V1.Company
{
    public partial class Index
    {
        public Recordings.Index Recordings(string recordingId = null)
        {
            return new Recordings.Index(this, recordingId);
        }
    }
}