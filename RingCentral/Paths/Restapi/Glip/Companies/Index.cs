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

        public async Task<RingCentral.GlipCompany> Get()
        {
            if (this.companyId == null)
            {
                throw new System.ArgumentNullException("companyId");
            }

            return await rc.Get<RingCentral.GlipCompany>(this.Path());
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