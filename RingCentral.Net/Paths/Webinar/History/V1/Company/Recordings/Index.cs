using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Webinar.History.V1.Company.Recordings
{
    public partial class Index
    {
        public RestClient rc;
        public Webinar.History.V1.Company.Index parent;
        public string recordingId;
        public Index(Webinar.History.V1.Company.Index parent, string recordingId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.recordingId = recordingId;
        }
        public string Path(bool withParameter = true)
        {
            if (withParameter && recordingId != null)
            {
                return $"{parent.Path()}/recordings/{recordingId}";
            }
            return $"{parent.Path()}/recordings";
        }
        /// <summary>
        /// Returns the list of webinar recordings (Administrator's interface).
        /// The user must have "WebinarSettings" permission granted otherwise the API returns HTTP 403.
        /// 
        /// HTTP Method: get
        /// Endpoint: /webinar/history/v1/company/recordings
        /// Rate Limit Group: Heavy
        /// App Permission: ReadWebinars
        /// </summary>
        public async Task<RingCentral.RecordingAdminListResource> List(RingCentral.RcwHistoryAdminListRecordingsParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.RecordingAdminListResource>(this.Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        /// Returns the webinar recording by ID (Administrator's interface).
        /// 
        /// The user must have "WebinarSettings" permission granted otherwise the API returns HTTP 403.
        /// 
        /// HTTP Method: get
        /// Endpoint: /webinar/history/v1/company/recordings/{recordingId}
        /// Rate Limit Group: Heavy
        /// App Permission: ReadWebinars
        /// </summary>
        public async Task<RingCentral.RecordingAdminExtendedItemModel> Get(RestRequestConfig restRequestConfig = null)
        {
            if (recordingId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(recordingId));
            }
            return await rc.Get<RingCentral.RecordingAdminExtendedItemModel>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Webinar.History.V1.Company
{
    public partial class Index
    {
        public Webinar.History.V1.Company.Recordings.Index Recordings(string recordingId = null)
        {
            return new Webinar.History.V1.Company.Recordings.Index(this, recordingId);
        }
    }
}