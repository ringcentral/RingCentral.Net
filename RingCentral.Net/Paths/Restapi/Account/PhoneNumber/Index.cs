using System.Threading.Tasks;
using System.Threading;

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

        /// <summary>
        /// Operation: Get Company Phone Number List
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/phone-number
        /// Rate Limit Group: Heavy
        /// App Permission: ReadAccounts
        /// User Permission: ReadCompanyPhoneNumbers
        /// </summary>
        public async Task<RingCentral.AccountPhoneNumbers> List(ListAccountPhoneNumbersParameters queryParams = null,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Get<RingCentral.AccountPhoneNumbers>(this.Path(false), queryParams, cancellationToken);
        }

        /// <summary>
        /// Operation: Get Phone Number
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/phone-number/{phoneNumberId}
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// User Permission: ReadCompanyPhoneNumbers
        /// </summary>
        public async Task<RingCentral.CompanyPhoneNumberInfo> Get(CancellationToken? cancellationToken = null)
        {
            if (this.phoneNumberId == null)
            {
                throw new System.ArgumentNullException("phoneNumberId");
            }

            return await rc.Get<RingCentral.CompanyPhoneNumberInfo>(this.Path(), null, cancellationToken);
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