using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.TeamMessaging.Companies
{
    public class Index
    {
        public string companyId;
        public TeamMessaging.Index parent;
        public RestClient rc;

        public Index(TeamMessaging.Index parent, string companyId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.companyId = companyId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && companyId != null) return $"{parent.Path()}/companies/{companyId}";
            return $"{parent.Path()}/companies";
        }

        /// <summary>
        ///     Returns information about one or more companies by their IDs.
        ///     HTTP Method: get
        ///     Endpoint: /team-messaging/{version}/companies/{companyId}
        ///     Rate Limit Group: Light
        ///     App Permission: TeamMessaging
        /// </summary>
        public async Task<TMCompanyInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            if (companyId == null) throw new ArgumentException("Parameter cannot be null", nameof(companyId));
            return await rc.Get<TMCompanyInfo>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.TeamMessaging
{
    public partial class Index
    {
        public Companies.Index Companies(string companyId = null)
        {
            return new Companies.Index(this, companyId);
        }
    }
}