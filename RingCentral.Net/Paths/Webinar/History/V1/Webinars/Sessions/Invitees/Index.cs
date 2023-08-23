using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Webinar.History.V1.Webinars.Sessions.Invitees
{
    public class Index
    {
        public string inviteeId;
        public Sessions.Index parent;
        public RestClient rc;

        public Index(Sessions.Index parent, string inviteeId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.inviteeId = inviteeId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && inviteeId != null) return $"{parent.Path()}/invitees/{inviteeId}";
            return $"{parent.Path()}/invitees";
        }

        /// <summary>
        ///     Returns the list of Invitees (co-hosts and panelists) of a given Webinar Session (host interface).
        ///     An implicit record created for a Webinar 'Host' is always returned.
        ///     HTTP Method: get
        ///     Endpoint: /webinar/history/v1/webinars/{webinarId}/sessions/{sessionId}/invitees
        ///     Rate Limit Group: Heavy
        ///     App Permission: ReadWebinars
        /// </summary>
        public async Task<InviteeListResource> List(RcwHistoryListInviteesParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<InviteeListResource>(Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Returns a historical session invitee information by ID (host interface).
        ///     HTTP Method: get
        ///     Endpoint: /webinar/history/v1/webinars/{webinarId}/sessions/{sessionId}/invitees/{inviteeId}
        ///     Rate Limit Group: Heavy
        ///     App Permission: ReadWebinars
        /// </summary>
        public async Task<InviteeModel> Get(RestRequestConfig restRequestConfig = null)
        {
            if (inviteeId == null) throw new ArgumentException("Parameter cannot be null", nameof(inviteeId));
            return await rc.Get<InviteeModel>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Webinar.History.V1.Webinars.Sessions
{
    public partial class Index
    {
        public Invitees.Index Invitees(string inviteeId = null)
        {
            return new Invitees.Index(this, inviteeId);
        }
    }
}