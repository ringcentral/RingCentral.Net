using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Glip.Companies
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Glip.Index parent;
        public string companyId;

        public Index(Restapi.Glip.Index parent, string companyId = null)
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
        /// Endpoint: /restapi/{apiVersion}/glip/companies/{companyId}
        /// Rate Limit Group: Light
        /// App Permission: TeamMessaging
        /// User Permission: UnifiedAppDesktop
        /// </summary>
        public async Task<RingCentral.GlipCompany> Get(RestRequestConfig restRequestConfig = null)
        {
            if (companyId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(companyId));
            }

            return await rc.Get<RingCentral.GlipCompany>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip
{
    public partial class Index
    {
        public Restapi.Glip.Companies.Index Companies(string companyId = null)
        {
            return new Restapi.Glip.Companies.Index(this, companyId);
        }
    }
}