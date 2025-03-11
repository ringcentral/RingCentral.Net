using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Webinar.Configuration.V1.Webinars.Sessions
{
    public partial class Index
    {
        public Webinars.Index parent;
        public RestClient rc;
        public string sessionId;

        public Index(Webinars.Index parent, string sessionId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.sessionId = sessionId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && sessionId != null) return $"{parent.Path()}/sessions/{sessionId}";
            return $"{parent.Path()}/sessions";
        }

        /// <summary>
        ///     Creates a new Session for a given Webinar
        ///     HTTP Method: post
        ///     Endpoint: /webinar/configuration/v1/webinars/{webinarId}/sessions
        ///     Rate Limit Group: Heavy
        ///     App Permission: EditWebinars
        /// </summary>
        public async Task<WcsSessionResource> Post(WcsSessionWithLocaleCodeModel wcsSessionWithLocaleCodeModel,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<WcsSessionResource>(Path(false), wcsSessionWithLocaleCodeModel, null,
                restRequestConfig);
        }

        /// <summary>
        ///     Returns a Webinar Session by ID.
        ///     HTTP Method: get
        ///     Endpoint: /webinar/configuration/v1/webinars/{webinarId}/sessions/{sessionId}
        ///     Rate Limit Group: Heavy
        ///     App Permission: ReadWebinars
        /// </summary>
        public async Task<WcsSessionResource> Get(RestRequestConfig restRequestConfig = null)
        {
            if (sessionId == null) throw new ArgumentException("Parameter cannot be null", nameof(sessionId));
            return await rc.Get<WcsSessionResource>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Deletes a Webinar Session. All child objects (Invitees) will be also deleted.
        ///     It is disallowed to delete a Session which is in 'Active' or 'Finished' state
        ///     HTTP Method: delete
        ///     Endpoint: /webinar/configuration/v1/webinars/{webinarId}/sessions/{sessionId}
        ///     Rate Limit Group: Heavy
        ///     App Permission: EditWebinars
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            if (sessionId == null) throw new ArgumentException("Parameter cannot be null", nameof(sessionId));
            return await rc.Delete<string>(Path(), null, null, restRequestConfig);
        }

        /// <summary>
        ///     Updates a Webinar Session. The payload may contain certain attributes from the Session resource
        ///     (it is a partial update). Changing the 'status' field usually invokes certain workflow actions.
        ///     Updating a Session in 'Active' or 'Finished' status is prohibited.
        ///     Some status transitions (for example, to 'Active" or 'Finished') may be prohibited.
        ///     HTTP Method: patch
        ///     Endpoint: /webinar/configuration/v1/webinars/{webinarId}/sessions/{sessionId}
        ///     Rate Limit Group: Heavy
        ///     App Permission: EditWebinars
        /// </summary>
        public async Task<WcsSessionResource> Patch(WcsSessionWithLocaleCodeModel wcsSessionWithLocaleCodeModel,
            RestRequestConfig restRequestConfig = null)
        {
            if (sessionId == null) throw new ArgumentException("Parameter cannot be null", nameof(sessionId));
            return await rc.Patch<WcsSessionResource>(Path(), wcsSessionWithLocaleCodeModel, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Webinar.Configuration.V1.Webinars
{
    public partial class Index
    {
        public Sessions.Index Sessions(string sessionId = null)
        {
            return new Sessions.Index(this, sessionId);
        }
    }
}