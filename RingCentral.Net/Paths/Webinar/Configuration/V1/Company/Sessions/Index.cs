using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Webinar.Configuration.V1.Company.Sessions
{
    public partial class Index
    {
        public RestClient rc;
public Webinar.Configuration.V1.Company.Index parent;
public Index(Webinar.Configuration.V1.Company.Index parent)
      {
this.parent = parent;
this.rc = parent.rc;
}
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/sessions";
        }
        /// <summary>
        /// Returns the list of Webinar Sessions hosted by all company users or particular user(s) sorted by
/// 'scheduledStartTime' or 'creationTime' (if 'scheduledStartTime' is not set) in the ascending ordered.
/// The user must have "WebinarSettings" permission granted otherwise the API returns HTTP 403.
/// 
        /// HTTP Method: get
        /// Endpoint: /webinar/configuration/v1/company/sessions
        /// Rate Limit Group: Heavy
        /// App Permission: ReadWebinars
        /// </summary>
  public async Task<RingCentral.WcsSessionGlobalListResource> Get(RingCentral.RcwConfigListAllCompanySessionsParameters queryParams = null, RestRequestConfig restRequestConfig = null)
  {
return await rc.Get<RingCentral.WcsSessionGlobalListResource>(this.Path(), queryParams, restRequestConfig);
  }
    }
}

namespace RingCentral.Paths.Webinar.Configuration.V1.Company
{
    public partial class Index
    {
        public Webinar.Configuration.V1.Company.Sessions.Index Sessions()
        {
            return new Webinar.Configuration.V1.Company.Sessions.Index(this);
        }
    }
}