using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Glip.Companies
{
    public class Index
    {
        public string companyId;
        public Glip.Index parent;
        public RestClient rc;

        public Index(Glip.Index parent, string companyId = null)
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
        ///     Endpoint: /restapi/{apiVersion}/glip/companies/{companyId}
        ///     Rate Limit Group: Light
        ///     App Permission: TeamMessaging
        ///     User Permission: UnifiedAppDesktop
        /// </summary>
        public async Task<GlipCompany> Get(RestRequestConfig restRequestConfig = null)
        {
            if (companyId == null) throw new ArgumentException("Parameter cannot be null", nameof(companyId));

            return await rc.Get<GlipCompany>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip
{
    public partial class Index
    {
        public Companies.Index Companies(string companyId = null)
        {
            return new Companies.Index(this, companyId);
        }
    }
}