using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.PhoneNumber
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Extension.Index parent;

        public Index(Restapi.Account.Extension.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/phone-number";
        }

        public class GetQueryParams
        {
            // Usage type of a phone number
            public string usageType;

            // Indicates the page number to retrieve. Only positive number values are allowed. Default value is '1'
            public string page;

            // Indicates the page size (number of items). If not specified, the value is '100' by default
            public string perPage;
        }

        public async Task<RingCentral.GetExtensionPhoneNumbersResponse> Get(GetQueryParams queryParams = null)
        {
            return await rc.Get<RingCentral.GetExtensionPhoneNumbersResponse>(this.Path(), queryParams);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.PhoneNumber.Index PhoneNumber()
        {
            return new Restapi.Account.Extension.PhoneNumber.Index(this);
        }
    }
}