using System.Threading.Tasks;

namespace RingCentral.Paths.Webinar.Configuration.V1.Company.Sessions
{
    public class Index
    {
        public Company.Index parent;
        public RestClient rc;

        public Index(Company.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/sessions";
        }

        /// <summary>
        ///     Returns the list of Webinar Sessions hosted by all company users or particular user(s) sorted by
        ///     'scheduledStartTime' or 'creationTime' (if 'scheduledStartTime' is not set) in the ascending ordered.
        ///     The user must have "WebinarSettings" permission granted otherwise the API returns HTTP 403.
        ///     HTTP Method: get
        ///     Endpoint: /webinar/configuration/v1/company/sessions
        ///     Rate Limit Group: Heavy
        ///     App Permission: ReadWebinars
        /// </summary>
        public async Task<WcsSessionGlobalListResource> Get(
            RcwConfigListAllCompanySessionsParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<WcsSessionGlobalListResource>(Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Webinar.Configuration.V1.Company
{
    public partial class Index
    {
        public Sessions.Index Sessions()
        {
            return new Sessions.Index(this);
        }
    }
}