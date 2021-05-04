using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.Extension.Meeting
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Extension.Index parent;
        public string meetingId;

        public Index(Restapi.Account.Extension.Index parent, string meetingId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.meetingId = meetingId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && meetingId != null)
            {
                return $"{parent.Path()}/meeting/{meetingId}";
            }

            return $"{parent.Path()}/meeting";
        }

        /// <summary>
        /// Returns a list of user meetings scheduled for the future (meetings of 'Instant' type are not included).
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/meeting
        /// Rate Limit Group: Light
        /// App Permission: Meetings
        /// User Permission: Meetings
        /// </summary>
        public async Task<RingCentral.MeetingsResource> List(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.MeetingsResource>(this.Path(false), null, restRequestConfig);
        }

        /// <summary>
        /// Creates a new meeting.
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/meeting
        /// Rate Limit Group: Medium
        /// App Permission: Meetings
        /// User Permission: Meetings
        /// </summary>
        public async Task<RingCentral.MeetingResponseResource> Post(
            RingCentral.MeetingRequestResource meetingRequestResource, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.MeetingResponseResource>(this.Path(false), meetingRequestResource, null,
                restRequestConfig);
        }

        /// <summary>
        /// Returns a particular meetings details by ID.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/meeting/{meetingId}
        /// Rate Limit Group: Light
        /// App Permission: Meetings
        /// User Permission: Meetings
        /// </summary>
        public async Task<RingCentral.MeetingResponseResource> Get(RestRequestConfig restRequestConfig = null)
        {
            if (meetingId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(meetingId));
            }

            return await rc.Get<RingCentral.MeetingResponseResource>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Modifies a particular meeting.
        /// HTTP Method: put
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/meeting/{meetingId}
        /// Rate Limit Group: Medium
        /// App Permission: Meetings
        /// User Permission: Meetings
        /// </summary>
        public async Task<RingCentral.MeetingResponseResource> Put(
            RingCentral.MeetingRequestResource meetingRequestResource, RestRequestConfig restRequestConfig = null)
        {
            if (meetingId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(meetingId));
            }

            return await rc.Put<RingCentral.MeetingResponseResource>(this.Path(), meetingRequestResource, null,
                restRequestConfig);
        }

        /// <summary>
        /// Deletes a scheduled meeting.
        /// HTTP Method: delete
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/meeting/{meetingId}
        /// Rate Limit Group: Medium
        /// App Permission: Meetings
        /// User Permission: Meetings
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            if (meetingId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(meetingId));
            }

            return await rc.Delete<string>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.Meeting.Index Meeting(string meetingId = null)
        {
            return new Restapi.Account.Extension.Meeting.Index(this, meetingId);
        }
    }
}