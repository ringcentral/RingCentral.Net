using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Meeting
{
    public partial class Index
    {
        public string meetingId;
        public Account.Index parent;
        public RestClient rc;

        public Index(Account.Index parent, string meetingId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.meetingId = meetingId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && meetingId != null) return $"{parent.Path()}/meeting/{meetingId}";
            return $"{parent.Path()}/meeting";
        }

        /// <summary>
        ///     Returns a particular account-level meeting details by ID.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/meeting/{meetingId}
        ///     Rate Limit Group: Light
        ///     App Permission: Meetings
        ///     User Permission: Meetings
        /// </summary>
        public async Task<MeetingResponseResource> Get(RestRequestConfig restRequestConfig = null)
        {
            if (meetingId == null) throw new ArgumentException("Parameter cannot be null", nameof(meetingId));
            return await rc.Get<MeetingResponseResource>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public Meeting.Index Meeting(string meetingId = null)
        {
            return new Meeting.Index(this, meetingId);
        }
    }
}