using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Webinar.Configuration.V1.Webinars
{
    public partial class Index
    {
        public V1.Index parent;
        public RestClient rc;
        public string webinarId;

        public Index(V1.Index parent, string webinarId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.webinarId = webinarId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && webinarId != null) return $"{parent.Path()}/webinars/{webinarId}";
            return $"{parent.Path()}/webinars";
        }

        /// <summary>
        ///     Returns the list of Webinars hosted by a current authorized user sorted by 'scheduledStartTime' or 'creationTime'
        ///     in the ascending order.
        ///     HTTP Method: get
        ///     Endpoint: /webinar/configuration/v1/webinars
        ///     Rate Limit Group: Heavy
        ///     App Permission: ReadWebinars
        /// </summary>
        public async Task<WebinarListResource> List(RcwConfigListWebinarsParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<WebinarListResource>(Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Creates a new webinar.
        ///     If "host" parameter is NOT passed then the current authorized user will become a Host.
        ///     If "host" parameter is passed then the caller must be a company administrator and have "WebinarSettings"
        ///     permission.
        ///     "host.linkedUser.accountId" must be the same as authorized user's account ID.
        ///     The webinar settings which are not mandated at account level or are unlocked can be
        ///     specified. All other settings are defaulted according to account policy.
        ///     HTTP Method: post
        ///     Endpoint: /webinar/configuration/v1/webinars
        ///     Rate Limit Group: Heavy
        ///     App Permission: EditWebinars
        /// </summary>
        public async Task<WcsWebinarResource> Post(WebinarCreationRequest webinarCreationRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<WcsWebinarResource>(Path(false), webinarCreationRequest, null, restRequestConfig);
        }

        /// <summary>
        ///     Returns a Webinar information by ID.
        ///     Some webinar settings are returned basing on webinar-level overrides, other - from default settings defined at
        ///     account level.
        ///     HTTP Method: get
        ///     Endpoint: /webinar/configuration/v1/webinars/{webinarId}
        ///     Rate Limit Group: Heavy
        ///     App Permission: ReadWebinars
        /// </summary>
        public async Task<WcsWebinarResource> Get(RestRequestConfig restRequestConfig = null)
        {
            if (webinarId == null) throw new ArgumentException("Parameter cannot be null", nameof(webinarId));
            return await rc.Get<WcsWebinarResource>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Deletes a Webinar by ID. All child objects (Sessions, Invitees) will be also deleted.
        ///     It is disallowed to delete a Webinar which has at least one Session in 'Active' or 'Finished' state.
        ///     HTTP Method: delete
        ///     Endpoint: /webinar/configuration/v1/webinars/{webinarId}
        ///     Rate Limit Group: Heavy
        ///     App Permission: EditWebinars
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            if (webinarId == null) throw new ArgumentException("Parameter cannot be null", nameof(webinarId));
            return await rc.Delete<string>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Updates a Webinar. The payload may contain just changed fields of a Webinar resource (it is a partial update):
        ///     - host cannot be changed and host user information cannot be updated;
        ///     - only the settings which are not mandated at account level or are unlocked can be
        ///     changed;
        ///     - in order to reset a webinar password it should be passed as an empty string;
        ///     - "registrationStatus" cannot be changed.
        ///     HTTP Method: patch
        ///     Endpoint: /webinar/configuration/v1/webinars/{webinarId}
        ///     Rate Limit Group: Heavy
        ///     App Permission: EditWebinars
        /// </summary>
        public async Task<WcsWebinarResource> Patch(WebinarBaseModel webinarBaseModel,
            RestRequestConfig restRequestConfig = null)
        {
            if (webinarId == null) throw new ArgumentException("Parameter cannot be null", nameof(webinarId));
            return await rc.Patch<WcsWebinarResource>(Path(), webinarBaseModel, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Webinar.Configuration.V1
{
    public partial class Index
    {
        public Webinars.Index Webinars(string webinarId = null)
        {
            return new Webinars.Index(this, webinarId);
        }
    }
}