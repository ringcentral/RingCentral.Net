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

        public async Task<RingCentral.GetExtensionPhoneNumbersResponse> Get(GetQueryParams queryParams = null)
        {
            return await rc.Get<RingCentral.GetExtensionPhoneNumbersResponse>(this.Path(), queryParams);
        }

        public async Task<RingCentral.GetExtensionPhoneNumbersResponse> Get(object queryParams)
        {
            return await rc.Get<RingCentral.GetExtensionPhoneNumbersResponse>(this.Path(), queryParams);
        }
    }

    public class GetQueryParams
    {
        // Usage type of a phone number
        public string[] usageType;

        // Indicates the page number to retrieve. Only positive number values are allowed. Default value is '1'
        public long? page;

        // Indicates the page size (number of items). If not specified, the value is '100' by default
        public long? perPage;
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