using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.Meeting.ServiceInfo
{
    public class Index
    {
        public Meeting.Index parent;
        public RestClient rc;

        public Index(Meeting.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/service-info";
        }

        /// <summary>
        ///     Returns information on dial-in numbers for meetings, support and international dial-in numbers URIs and meeting
        ///     account information.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/meeting/service-info
        ///     Rate Limit Group: Light
        ///     App Permission: Meetings
        ///     User Permission: Meetings
        /// </summary>
        public async Task<MeetingServiceInfoResource> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<MeetingServiceInfoResource>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Updates personal meeting identifier.
        ///     HTTP Method: patch
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/meeting/service-info
        ///     Rate Limit Group: Medium
        ///     App Permission: Meetings
        ///     User Permission: Meetings
        /// </summary>
        public async Task<MeetingServiceInfoResource> Patch(MeetingServiceInfoRequest meetingServiceInfoRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Patch<MeetingServiceInfoResource>(Path(), meetingServiceInfoRequest, null,
                restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension.Meeting
{
    public partial class Index
    {
        public ServiceInfo.Index ServiceInfo()
        {
            return new ServiceInfo.Index(this);
        }
    }
}