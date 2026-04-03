using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Webinar.Configuration.V1.Webinars
{
    public partial class Index
    {
        public RestClient rc;
        public Webinar.Configuration.V1.Index parent;
        public string webinarId;
        public Index(Webinar.Configuration.V1.Index parent, string webinarId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.webinarId = webinarId;
        }
        public string Path(bool withParameter = true)
        {
            if (withParameter && webinarId != null)
            {
                return $"{parent.Path()}/webinars/{webinarId}";
            }
            return $"{parent.Path()}/webinars";
        }
        /// <summary>
        /// Returns the list of Webinars hosted by a current authorized user sorted by 'scheduledStartTime' or 'creationTime' in the ascending order.
        /// 
        /// HTTP Method: get
        /// Endpoint: /webinar/configuration/v1/webinars
        /// Rate Limit Group: Heavy
        /// App Permission: ReadWebinars
        /// </summary>
        public async Task<RingCentral.WebinarListResource> List(RingCentral.RcwConfigListWebinarsParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.WebinarListResource>(this.Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        /// Creates a new webinar.
        /// 
        /// If "host" parameter is NOT passed then the current authorized user will become a Host.
        /// If "host" parameter is passed then the caller must be a company administrator and have "WebinarSettings" permission.
        /// "host.linkedUser.accountId" must be the same as authorized user's account ID.
        /// 
        /// The webinar settings which are not mandated at account level or are unlocked can be
        /// specified. All other settings are defaulted according to account policy.
        /// 
        /// HTTP Method: post
        /// Endpoint: /webinar/configuration/v1/webinars
        /// Rate Limit Group: Heavy
        /// App Permission: EditWebinars
        /// </summary>
        public async Task<RingCentral.WcsWebinarResource> Post(RingCentral.WebinarCreationRequest webinarCreationRequest, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.WcsWebinarResource>(this.Path(false), webinarCreationRequest, null, restRequestConfig);
        }

        /// <summary>
        /// Returns a Webinar information by ID.
        /// Some webinar settings are returned basing on webinar-level overrides, other - from default settings defined at account level.
        /// 
        /// HTTP Method: get
        /// Endpoint: /webinar/configuration/v1/webinars/{webinarId}
        /// Rate Limit Group: Heavy
        /// App Permission: ReadWebinars
        /// </summary>
        public async Task<RingCentral.WcsWebinarResource> Get(RestRequestConfig restRequestConfig = null)
        {
            if (webinarId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(webinarId));
            }
            return await rc.Get<RingCentral.WcsWebinarResource>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Deletes a Webinar by ID. All child objects (Sessions, Invitees) will be also deleted.
        /// It is disallowed to delete a Webinar which has at least one Session in 'Active' or 'Finished' state.
        /// 
        /// HTTP Method: delete
        /// Endpoint: /webinar/configuration/v1/webinars/{webinarId}
        /// Rate Limit Group: Heavy
        /// App Permission: EditWebinars
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            if (webinarId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(webinarId));
            }
            return await rc.Delete<string>(this.Path(), null, null, restRequestConfig);
        }

        /// <summary>
        /// Updates a Webinar. The payload may contain just changed fields of a Webinar resource (it is a partial update):
        /// - host cannot be changed, and host user information cannot be updated;
        /// - only the settings which are not mandated at account level or are unlocked can be
        /// changed;
        /// - in order to reset a webinar password it should be passed as an empty string;
        /// - "registrationStatus" cannot be changed.
        /// 
        /// HTTP Method: patch
        /// Endpoint: /webinar/configuration/v1/webinars/{webinarId}
        /// Rate Limit Group: Heavy
        /// App Permission: EditWebinars
        /// </summary>
        public async Task<RingCentral.WcsWebinarResource> Patch(RingCentral.WebinarBaseModel webinarBaseModel, RestRequestConfig restRequestConfig = null)
        {
            if (webinarId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(webinarId));
            }
            return await rc.Patch<RingCentral.WcsWebinarResource>(this.Path(), webinarBaseModel, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Webinar.Configuration.V1
{
    public partial class Index
    {
        public Webinar.Configuration.V1.Webinars.Index Webinars(string webinarId = null)
        {
            return new Webinar.Configuration.V1.Webinars.Index(this, webinarId);
        }
    }
}