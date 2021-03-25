using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.Meeting.ServiceInfo
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Extension.Meeting.Index parent;

        public Index(Restapi.Account.Extension.Meeting.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/service-info";
        }

        /// <summary>
        /// Returns information on dial-in numbers for meetings, support and international dial-in numbers URIs and meeting account information.
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting/service-info
        /// Rate Limit Group: Light
        /// App Permission: Meetings
        /// User Permission: Meetings
        /// </summary>
        public async Task<RingCentral.MeetingServiceInfoResource> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.MeetingServiceInfoResource>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Updates personal meeting identifier.
        /// HTTP Method: PATCH
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting/service-info
        /// Rate Limit Group: Medium
        /// App Permission: Meetings
        /// User Permission: Meetings
        /// </summary>
        public async Task<RingCentral.MeetingServiceInfoResource> Patch(
            RingCentral.MeetingServiceInfoRequest meetingServiceInfoRequest, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Patch<RingCentral.MeetingServiceInfoResource>(this.Path(), meetingServiceInfoRequest, null,
                restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension.Meeting
{
    public partial class Index
    {
        public Restapi.Account.Extension.Meeting.ServiceInfo.Index ServiceInfo()
        {
            return new Restapi.Account.Extension.Meeting.ServiceInfo.Index(this);
        }
    }
}