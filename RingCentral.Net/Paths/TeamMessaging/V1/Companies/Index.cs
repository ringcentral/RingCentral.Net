using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.TeamMessaging.V1.Companies
{
    public partial class Index
    {
        public RestClient rc;
        public TeamMessaging.V1.Index parent;
        public string companyId;
        public Index(TeamMessaging.V1.Index parent, string companyId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.companyId = companyId;
        }
        public string Path(bool withParameter = true)
        {
            if (withParameter && companyId != null)
            {
                return $"{parent.Path()}/companies/{companyId}";
            }
            return $"{parent.Path()}/companies";
        }
        /// <summary>
        /// Returns information about one or more companies by their IDs.
        /// HTTP Method: get
        /// Endpoint: /team-messaging/v1/companies/{companyId}
        /// Rate Limit Group: Light
        /// App Permission: TeamMessaging
        /// </summary>
        public async Task<RingCentral.TMCompanyInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            if (companyId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(companyId));
            }
            return await rc.Get<RingCentral.TMCompanyInfo>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.TeamMessaging.V1
{
    public partial class Index
    {
        public TeamMessaging.V1.Companies.Index Companies(string companyId = null)
        {
            return new TeamMessaging.V1.Companies.Index(this, companyId);
        }
    }
}