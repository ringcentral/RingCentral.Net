using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.Meeting
{
    public partial class Index
    {
        public string meetingId;
        public Extension.Index parent;
        public RestClient rc;

        public Index(Extension.Index parent, string meetingId = null)
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
        ///     Returns a list of user meetings scheduled for the future (meetings of 'Instant' type are not included).
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/meeting
        ///     Rate Limit Group: Light
        ///     App Permission: Meetings
        ///     User Permission: Meetings
        /// </summary>
        public async Task<MeetingsResource> List(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<MeetingsResource>(Path(false), null, restRequestConfig);
        }

        /// <summary>
        ///     Creates a new meeting.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/meeting
        ///     Rate Limit Group: Medium
        ///     App Permission: Meetings
        ///     User Permission: Meetings
        /// </summary>
        public async Task<MeetingResponseResource> Post(
            MeetingRequestResource meetingRequestResource, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<MeetingResponseResource>(Path(false), meetingRequestResource, null,
                restRequestConfig);
        }

        /// <summary>
        ///     Returns a particular meetings details by ID.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/meeting/{meetingId}
        ///     Rate Limit Group: Light
        ///     App Permission: Meetings
        ///     User Permission: Meetings
        /// </summary>
        public async Task<MeetingResponseResource> Get(RestRequestConfig restRequestConfig = null)
        {
            if (meetingId == null) throw new ArgumentException("Parameter cannot be null", nameof(meetingId));

            return await rc.Get<MeetingResponseResource>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Modifies a particular meeting.
        ///     HTTP Method: put
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/meeting/{meetingId}
        ///     Rate Limit Group: Medium
        ///     App Permission: Meetings
        ///     User Permission: Meetings
        /// </summary>
        public async Task<MeetingResponseResource> Put(
            MeetingRequestResource meetingRequestResource, RestRequestConfig restRequestConfig = null)
        {
            if (meetingId == null) throw new ArgumentException("Parameter cannot be null", nameof(meetingId));

            return await rc.Put<MeetingResponseResource>(Path(), meetingRequestResource, null,
                restRequestConfig);
        }

        /// <summary>
        ///     Deletes a scheduled meeting.
        ///     HTTP Method: delete
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/meeting/{meetingId}
        ///     Rate Limit Group: Medium
        ///     App Permission: Meetings
        ///     User Permission: Meetings
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            if (meetingId == null) throw new ArgumentException("Parameter cannot be null", nameof(meetingId));

            return await rc.Delete<string>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Meeting.Index Meeting(string meetingId = null)
        {
            return new Meeting.Index(this, meetingId);
        }
    }
}