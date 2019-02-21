using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.BusinessHours
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Index parent;

        public Index(Restapi.Account.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/business-hours";
        }

        public async Task<RingCentral.CompanyBusinessHours> Get()
        {
            return await rc.Get<RingCentral.CompanyBusinessHours>(this.Path());
        }

        public async Task<RingCentral.CompanyBusinessHours> Put(
            RingCentral.CompanyBusinessHoursUpdateRequest companyBusinessHoursUpdateRequest)
        {
            return await rc.Put<RingCentral.CompanyBusinessHours>(this.Path(), companyBusinessHoursUpdateRequest);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public Restapi.Account.BusinessHours.Index BusinessHours()
        {
            return new Restapi.Account.BusinessHours.Index(this);
        }
    }
}