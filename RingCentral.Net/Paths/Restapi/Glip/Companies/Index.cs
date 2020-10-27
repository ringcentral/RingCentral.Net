using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Glip.Companies
{
    public partial class Index
    {
        public RestClient rc;
        public string companyId;
        public Restapi.Glip.Index parent;

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
        /// Operation: Get Company Info
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/glip/companies/{companyId}
        /// Rate Limit Group: Light
        /// App Permission: Glip
        /// User Permission: Glip
        /// </summary>
        public async Task<RingCentral.GlipCompany> Get(RestRequestConfig restRequestConfig = null)
        {
            if (this.companyId == null)
            {
                throw new System.ArgumentNullException("companyId");
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