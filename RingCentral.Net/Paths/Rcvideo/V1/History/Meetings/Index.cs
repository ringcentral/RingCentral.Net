using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Rcvideo.V1.History.Meetings
{
    public partial class Index
    {
        public RestClient rc;
        public Rcvideo.V1.History.Index parent;
        public string meetingId;
        public Index(Rcvideo.V1.History.Index parent, string meetingId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.meetingId = meetingId;
        }
        public string Path(bool withParameter = true)
        {
            if (withParameter && meetingId != null)
            {
                return $"{parent.Path()}/meetings/{meetingId}";
            }
            return $"{parent.Path()}/meetings";
        }
        /// <summary>
        /// Returns the list of user meetings.
        /// HTTP Method: get
        /// Endpoint: /rcvideo/v1/history/meetings
        /// Rate Limit Group: Light
        /// App Permission: Video
        /// </summary>
        public async Task<RingCentral.MeetingPage> List(RingCentral.ListVideoMeetingsParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.MeetingPage>(this.Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        /// Returns a user meeting by ID.
        /// HTTP Method: get
        /// Endpoint: /rcvideo/v1/history/meetings/{meetingId}
        /// Rate Limit Group: Light
        /// App Permission: Video
        /// </summary>
        public async Task<RingCentral.Meeting> Get(RestRequestConfig restRequestConfig = null)
        {
            if (meetingId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(meetingId));
            }
            return await rc.Get<RingCentral.Meeting>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Rcvideo.V1.History
{
    public partial class Index
    {
        public Rcvideo.V1.History.Meetings.Index Meetings(string meetingId = null)
        {
            return new Rcvideo.V1.History.Meetings.Index(this, meetingId);
        }
    }
}