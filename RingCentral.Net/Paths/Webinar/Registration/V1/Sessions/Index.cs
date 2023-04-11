using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Webinar.Registration.V1.Sessions
{
    public partial class Index
    {
        public V1.Index parent;
        public RestClient rc;
        public string sessionId;

        public Index(V1.Index parent, string sessionId = null)
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
        ///     Returns a registration Session information by ID.
        ///     A caller must be an authorized user: either a host of the webinar or an IT Admin:
        ///     a user from host's account with "WebinarSettings" permission.
        ///     HTTP Method: get
        ///     Endpoint: /webinar/registration/v1/sessions/{sessionId}
        ///     Rate Limit Group: Heavy
        ///     App Permission: ReadWebinars
        /// </summary>
        public async Task<RegSessionModel> Get(RestRequestConfig restRequestConfig = null)
        {
            if (sessionId == null) throw new ArgumentException("Parameter cannot be null", nameof(sessionId));
            return await rc.Get<RegSessionModel>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Updates a Session by ID.
        ///     This is a PARTIAL update (PATCH), client may call it providing only attributes which are to be changed.
        ///     A caller must be an authorized user: either a host of the webinar or an IT Admin:
        ///     a user from host's account with "WebinarSettings" permission.
        ///     If a session record with given ID doesn't exist on Registration Service side the API should return HTTP 404.
        ///     HTTP Method: patch
        ///     Endpoint: /webinar/registration/v1/sessions/{sessionId}
        ///     Rate Limit Group: Heavy
        ///     App Permission: EditWebinars
        /// </summary>
        public async Task<RegSessionModel> Patch(RegSessionModel regSessionModel,
            RestRequestConfig restRequestConfig = null)
        {
            if (sessionId == null) throw new ArgumentException("Parameter cannot be null", nameof(sessionId));
            return await rc.Patch<RegSessionModel>(Path(), regSessionModel, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Webinar.Registration.V1
{
    public partial class Index
    {
        public Sessions.Index Sessions(string sessionId = null)
        {
            return new Sessions.Index(this, sessionId);
        }
    }
}