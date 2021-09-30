using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.Meeting.Invitation
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
            return $"{parent.Path()}/invitation";
        }

        /// <summary>
        ///     Returns a meeting invitation by ID.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/meeting/{meetingId}/invitation
        ///     Rate Limit Group: Light
        ///     App Permission: Meetings
        ///     User Permission: Meetings
        /// </summary>
        public async Task<PublicMeetingInvitationResponse> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<PublicMeetingInvitationResponse>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension.Meeting
{
    public partial class Index
    {
        public Invitation.Index Invitation()
        {
            return new Invitation.Index(this);
        }
    }
}