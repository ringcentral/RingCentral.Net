using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Webinar.Registration.V1.Sessions.Registrants
{
    public class Index
    {
        public Sessions.Index parent;
        public RestClient rc;
        public string registrantId;

        public Index(Sessions.Index parent, string registrantId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.registrantId = registrantId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && registrantId != null) return $"{parent.Path()}/registrants/{registrantId}";
            return $"{parent.Path()}/registrants";
        }

        /// <summary>
        ///     Returns the list of Registrants ordered by "id" ascending.
        ///     A caller must be an authorized user: either a host of the webinar or an IT Admin:
        ///     a user from host's account with "WebinarSettings" permission.
        ///     HTTP Method: get
        ///     Endpoint: /webinar/registration/v1/sessions/{sessionId}/registrants
        ///     Rate Limit Group: Heavy
        ///     App Permission: ReadWebinars
        /// </summary>
        public async Task<RegistrantListResource> List(RcwRegListRegistrantsParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RegistrantListResource>(Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Creates a new Registrant for a given session.
        ///     Registration MUST be open for the session for this call to succeed (otherwise it should return HTTP 403).
        ///     A caller must be an authorized user: either a host of the webinar or an IT Admin:
        ///     a user from host's account with "WebinarSettings" permission.
        ///     HTTP Method: post
        ///     Endpoint: /webinar/registration/v1/sessions/{sessionId}/registrants
        ///     Rate Limit Group: Heavy
        ///     App Permission: EditWebinars
        /// </summary>
        public async Task<RegistrantModelResponsePostWithQuestionnaire> Post(
            RegistrantBaseModelWithQuestionnaire registrantBaseModelWithQuestionnaire,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RegistrantModelResponsePostWithQuestionnaire>(Path(false),
                registrantBaseModelWithQuestionnaire, null, restRequestConfig);
        }

        /// <summary>
        ///     Returns a Registrant by ID.
        ///     A caller must be an authorized user: either a host of the webinar or an IT Admin:
        ///     a user from host's account with "WebinarSettings" permission.
        ///     HTTP Method: get
        ///     Endpoint: /webinar/registration/v1/sessions/{sessionId}/registrants/{registrantId}
        ///     Rate Limit Group: Heavy
        ///     App Permission: ReadWebinars
        /// </summary>
        public async Task<RegistrantModelWithQuestionnaire> Get(RcwRegGetRegistrantParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            if (registrantId == null) throw new ArgumentException("Parameter cannot be null", nameof(registrantId));
            return await rc.Get<RegistrantModelWithQuestionnaire>(Path(), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Deletes a Registrant by ID.
        ///     Session must not be in finished state (otherwise it should return HTTP 403).
        ///     A caller must be an authorized user: either a host of the webinar or an IT Admin:
        ///     a user from host's account with "WebinarSettings" permission.
        ///     HTTP Method: delete
        ///     Endpoint: /webinar/registration/v1/sessions/{sessionId}/registrants/{registrantId}
        ///     Rate Limit Group: Heavy
        ///     App Permission: EditWebinars
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            if (registrantId == null) throw new ArgumentException("Parameter cannot be null", nameof(registrantId));
            return await rc.Delete<string>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Webinar.Registration.V1.Sessions
{
    public partial class Index
    {
        public Registrants.Index Registrants(string registrantId = null)
        {
            return new Registrants.Index(this, registrantId);
        }
    }
}