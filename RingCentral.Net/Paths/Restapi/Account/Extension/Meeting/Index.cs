using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.Meeting
{
    public partial class Index
    {
        public RestClient rc;
        public string meetingId;
        public Restapi.Account.Extension.Index parent;

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
        /// Operation: Get Scheduled Meetings
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting
        /// Rate Limit Group: Light
        /// App Permission: Meetings
        /// User Permission: Meetings
        /// </summary>
        public async Task<RingCentral.MeetingsResource> List(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.MeetingsResource>(this.Path(false), null, restRequestConfig);
        }

        /// <summary>
        /// Operation: Create Meeting
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting
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
        /// Operation: Get Meeting Info
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting/{meetingId}
        /// Rate Limit Group: Light
        /// App Permission: Meetings
        /// User Permission: Meetings
        /// </summary>
        public async Task<RingCentral.MeetingResponseResource> Get(RestRequestConfig restRequestConfig = null)
        {
            if (this.meetingId == null)
            {
                throw new System.ArgumentNullException("meetingId");
            }

            return await rc.Get<RingCentral.MeetingResponseResource>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Operation: Update Meeting
        /// HTTP Method: PUT
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting/{meetingId}
        /// Rate Limit Group: Medium
        /// App Permission: Meetings
        /// User Permission: Meetings
        /// </summary>
        public async Task<RingCentral.MeetingResponseResource> Put(
            RingCentral.MeetingRequestResource meetingRequestResource, RestRequestConfig restRequestConfig = null)
        {
            if (this.meetingId == null)
            {
                throw new System.ArgumentNullException("meetingId");
            }

            return await rc.Put<RingCentral.MeetingResponseResource>(this.Path(), meetingRequestResource, null,
                restRequestConfig);
        }

        /// <summary>
        /// Operation: Delete Meeting
        /// HTTP Method: DELETE
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting/{meetingId}
        /// Rate Limit Group: Medium
        /// App Permission: Meetings
        /// User Permission: Meetings
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            if (this.meetingId == null)
            {
                throw new System.ArgumentNullException("meetingId");
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