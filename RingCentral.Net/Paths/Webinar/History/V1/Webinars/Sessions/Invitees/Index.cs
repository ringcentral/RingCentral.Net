using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Webinar.History.V1.Webinars.Sessions.Invitees
{
    public partial class Index
    {
        public RestClient rc;
public Webinar.History.V1.Webinars.Sessions.Index parent;
public string inviteeId;
public Index(Webinar.History.V1.Webinars.Sessions.Index parent, string inviteeId = null)
      {
this.parent = parent;
this.rc = parent.rc;
this.inviteeId = inviteeId;
}
        public string Path(bool withParameter = true)
        {
            if (withParameter && inviteeId != null)
            {
                return $"{parent.Path()}/invitees/{inviteeId}";
            }
            return $"{parent.Path()}/invitees";
        }
        /// <summary>
        /// Returns the list of Invitees (co-hosts and panelists) of a given Webinar Session (host interface).
/// An implicit record created for a Webinar 'Host' is always returned.
/// 
        /// HTTP Method: get
        /// Endpoint: /webinar/history/v1/webinars/{webinarId}/sessions/{sessionId}/invitees
        /// Rate Limit Group: Heavy
        /// App Permission: ReadWebinars
        /// </summary>
  public async Task<RingCentral.InviteeListResource> List(RingCentral.RcwHistoryListInviteesParameters queryParams = null, RestRequestConfig restRequestConfig = null)
  {
return await rc.Get<RingCentral.InviteeListResource>(this.Path(false), queryParams, restRequestConfig);
  }

        /// <summary>
        /// Returns a historical session invitee information by ID (host interface).
        /// HTTP Method: get
        /// Endpoint: /webinar/history/v1/webinars/{webinarId}/sessions/{sessionId}/invitees/{inviteeId}
        /// Rate Limit Group: Heavy
        /// App Permission: ReadWebinars
        /// </summary>
  public async Task<RingCentral.InviteeModel> Get(RestRequestConfig restRequestConfig = null)
  {
if (inviteeId == null)
    {
        throw new System.ArgumentException("Parameter cannot be null", nameof(inviteeId));
    }return await rc.Get<RingCentral.InviteeModel>(this.Path(), null, restRequestConfig);
  }
    }
}

namespace RingCentral.Paths.Webinar.History.V1.Webinars.Sessions
{
    public partial class Index
    {
        public Webinar.History.V1.Webinars.Sessions.Invitees.Index Invitees(string inviteeId = null)
        {
            return new Webinar.History.V1.Webinars.Sessions.Invitees.Index(this, inviteeId);
        }
    }
}