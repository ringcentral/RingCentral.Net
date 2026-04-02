using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Webinar.Configuration.V1.Webinars.Sessions.Invitees
{
    public partial class Index
    {
        public RestClient rc;
public Webinar.Configuration.V1.Webinars.Sessions.Index parent;
public string inviteeId;
public Index(Webinar.Configuration.V1.Webinars.Sessions.Index parent, string inviteeId = null)
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
        /// Returns the list of Invitees (co-hosts and panelists in phase 1
/// and also invited attendees in subsequent phases) of a given Webinar Session.
/// An implicit record created for a Webinar 'Host' is always returned.
/// 
        /// HTTP Method: get
        /// Endpoint: /webinar/configuration/v1/webinars/{webinarId}/sessions/{sessionId}/invitees
        /// Rate Limit Group: Heavy
        /// App Permission: ReadWebinars
        /// </summary>
  public async Task<RingCentral.WcsInviteeListResource> List(RingCentral.RcwConfigListInviteesParameters queryParams = null, RestRequestConfig restRequestConfig = null)
  {
return await rc.Get<RingCentral.WcsInviteeListResource>(this.Path(false), queryParams, restRequestConfig);
  }

        /// <summary>
        /// Adds, updates and deletes Webinar Session invitees in bulk (co-hosts and panelists in phase 1
/// and also invited attendees in subsequent phases).
/// The payload may contain multiple added, updated or deleted invitees.
/// For each added record 'role' and either 'firstName'/'lastName'/'email' (for non-authenticated users)
/// or 'linkedUser.*' (for authenticated users) must be specified, but not both.
/// For updated invitees 'id'  and 'role' must be specified, 'linkedUser' change is not supported.
/// For deleted invitees only there ids should be specified.
/// The response contains added/updated records (full) and deleted records (ids only).
/// 
/// Deleting an invitee for a Session in 'Active' or 'Finished' status is prohibited.
/// 
        /// HTTP Method: patch
        /// Endpoint: /webinar/configuration/v1/webinars/{webinarId}/sessions/{sessionId}/invitees
        /// Rate Limit Group: Heavy
        /// App Permission: EditWebinars
        /// </summary>
  public async Task<RingCentral.BulkUpdateInviteesResponse> Patch(RingCentral.BulkUpdateInviteesRequest bulkUpdateInviteesRequest, RestRequestConfig restRequestConfig = null)
  {
return await rc.Patch<RingCentral.BulkUpdateInviteesResponse>(this.Path(false), bulkUpdateInviteesRequest, null, restRequestConfig);
  }

        /// <summary>
        /// Returns a Session Invitee information by ID
        /// HTTP Method: get
        /// Endpoint: /webinar/configuration/v1/webinars/{webinarId}/sessions/{sessionId}/invitees/{inviteeId}
        /// Rate Limit Group: Heavy
        /// App Permission: ReadWebinars
        /// </summary>
  public async Task<RingCentral.InviteeResource> Get(RestRequestConfig restRequestConfig = null)
  {
if (inviteeId == null)
    {
        throw new System.ArgumentException("Parameter cannot be null", nameof(inviteeId));
    }return await rc.Get<RingCentral.InviteeResource>(this.Path(), null, restRequestConfig);
  }

        /// <summary>
        /// Updates a Session Invitee. 'role' is required (it can be changed from 'Panelist' to 'CoHost' or vise versa).
/// It is disallowed to update 'linkedUser': it should be done by deleting then adding an invitee.
/// For non-authenticated users 'firstName'/'lastName'/'email' can be specified, but not both.
/// Implicit record created for a Webinar 'Host' cannot be modified.
/// Also it is disallowed to change any other role to 'Host'.
/// 
        /// HTTP Method: put
        /// Endpoint: /webinar/configuration/v1/webinars/{webinarId}/sessions/{sessionId}/invitees/{inviteeId}
        /// Rate Limit Group: Heavy
        /// App Permission: EditWebinars
        /// </summary>
  public async Task<RingCentral.InviteeResource> Put(RingCentral.UpdateInviteeRequest updateInviteeRequest, RestRequestConfig restRequestConfig = null)
  {
if (inviteeId == null)
    {
        throw new System.ArgumentException("Parameter cannot be null", nameof(inviteeId));
    }return await rc.Put<RingCentral.InviteeResource>(this.Path(), updateInviteeRequest, null, restRequestConfig);
  }

        /// <summary>
        /// Deletes a Session Invitee. Implicit record created for a Webinar 'Host' cannot be deleted.
/// Deleting an invitee for a Session in 'Active' or 'Finished' status is prohibited (HTTP 403).
/// 
        /// HTTP Method: delete
        /// Endpoint: /webinar/configuration/v1/webinars/{webinarId}/sessions/{sessionId}/invitees/{inviteeId}
        /// Rate Limit Group: Heavy
        /// App Permission: EditWebinars
        /// </summary>
  public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
  {
if (inviteeId == null)
    {
        throw new System.ArgumentException("Parameter cannot be null", nameof(inviteeId));
    }return await rc.Delete<string>(this.Path(), null, null, restRequestConfig);
  }
    }
}

namespace RingCentral.Paths.Webinar.Configuration.V1.Webinars.Sessions
{
    public partial class Index
    {
        public Webinar.Configuration.V1.Webinars.Sessions.Invitees.Index Invitees(string inviteeId = null)
        {
            return new Webinar.Configuration.V1.Webinars.Sessions.Invitees.Index(this, inviteeId);
        }
    }
}