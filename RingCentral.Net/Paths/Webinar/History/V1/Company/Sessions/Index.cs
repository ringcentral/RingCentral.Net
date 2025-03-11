using System.Threading.Tasks;

namespace RingCentral.Paths.Webinar.History.V1.Company.Sessions
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
        ///     Returns the list of historical Webinar Sessions hosted by particular user(s) or all company users
        ///     sorted by 'endTime' in the descending order. Depending on a session status 'endTime' can
        ///     represent actual end time or scheduled end time.
        ///     The user must have "WebinarSettings" permission granted otherwise the API returns HTTP 403.
        ///     HTTP Method: get
        ///     Endpoint: /webinar/history/v1/company/sessions
        ///     Rate Limit Group: Heavy
        ///     App Permission: ReadWebinars
        /// </summary>
        public async Task<SessionGlobalListResource> Get(RcwHistoryListAllCompanySessionsParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<SessionGlobalListResource>(Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Webinar.History.V1.Company
{
    public partial class Index
    {
        public Sessions.Index Sessions()
        {
            return new Sessions.Index(this);
        }
    }
}