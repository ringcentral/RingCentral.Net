using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Webinar.History.V1.Webinars.Sessions
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
        ///     Returns a historical webinar Session by ID. Access allowed to participants with original role as CoHost.
        ///     HTTP Method: get
        ///     Endpoint: /webinar/history/v1/webinars/{webinarId}/sessions/{sessionId}
        ///     Rate Limit Group: Heavy
        ///     App Permission: ReadWebinars
        /// </summary>
        public async Task<SessionResource> Get(RestRequestConfig restRequestConfig = null)
        {
            if (sessionId == null) throw new ArgumentException("Parameter cannot be null", nameof(sessionId));
            return await rc.Get<SessionResource>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Webinar.History.V1.Webinars
{
    public partial class Index
    {
        public Sessions.Index Sessions(string sessionId = null)
        {
            return new Sessions.Index(this, sessionId);
        }
    }
}