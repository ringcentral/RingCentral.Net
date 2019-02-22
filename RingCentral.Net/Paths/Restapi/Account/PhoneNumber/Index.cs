using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.PhoneNumber
{
    public partial class Index
    {
        public RestClient rc;
        public string phoneNumberId;
        public Restapi.Account.Index parent;

        public Index(Restapi.Account.Index parent, string phoneNumberId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.phoneNumberId = phoneNumberId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && phoneNumberId != null)
            {
                return $"{parent.Path()}/phone-number/{phoneNumberId}";
            }

            return $"{parent.Path()}/phone-number";
        }

        public async Task<RingCentral.AccountPhoneNumbers> List(ListAccountPhoneNumbersParameters queryParams = null)
        {
            return await rc.Get<RingCentral.AccountPhoneNumbers>(this.Path(false), queryParams);
        }

        public async Task<RingCentral.CompanyPhoneNumberInfo> Get()
        {
            if (this.phoneNumberId == null)
            {
                throw new System.ArgumentNullException("phoneNumberId");
            }

            return await rc.Get<RingCentral.CompanyPhoneNumberInfo>(this.Path());
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public Restapi.Account.PhoneNumber.Index PhoneNumber(string phoneNumberId = null)
        {
            return new Restapi.Account.PhoneNumber.Index(this, phoneNumberId);
        }
    }
}