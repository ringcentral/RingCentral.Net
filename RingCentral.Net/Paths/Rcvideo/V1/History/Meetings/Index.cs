using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Rcvideo.V1.History.Meetings
{
    public class Index
    {
        public string meetingId;
        public History.Index parent;
        public RestClient rc;

        public Index(History.Index parent, string meetingId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.meetingId = meetingId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && meetingId != null) return $"{parent.Path()}/meetings/{meetingId}";

            return $"{parent.Path()}/meetings";
        }

        /// <summary>
        ///     Returns the list of user meetings.
        ///     HTTP Method: get
        ///     Endpoint: /rcvideo/v1/history/meetings
        ///     Rate Limit Group: Light
        ///     App Permission: Video
        /// </summary>
        public async Task<MeetingPage> List(ListVideoMeetingsParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<MeetingPage>(Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Returns a user meeting by ID.
        ///     HTTP Method: get
        ///     Endpoint: /rcvideo/v1/history/meetings/{meetingId}
        ///     Rate Limit Group: Light
        ///     App Permission: Video
        /// </summary>
        public async Task<Meeting> Get(RestRequestConfig restRequestConfig = null)
        {
            if (meetingId == null) throw new ArgumentException("Parameter cannot be null", nameof(meetingId));

            return await rc.Get<Meeting>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Rcvideo.V1.History
{
    public partial class Index
    {
        public Meetings.Index Meetings(string meetingId = null)
        {
            return new Meetings.Index(this, meetingId);
        }
    }
}