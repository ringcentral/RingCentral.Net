using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.BusinessAddress
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
            return $"{parent.Path()}/business-address";
        }

        // Operation: loadAccountBusinessAddress
        public async Task<RingCentral.AccountBusinessAddressResource> Get()
        {
            return await rc.Get<RingCentral.AccountBusinessAddressResource>(this.Path());
        }

        // Operation: updateAccountBusinessAddress
        public async Task<RingCentral.AccountBusinessAddressResource> Put(
            RingCentral.ModifyAccountBusinessAddressRequest modifyAccountBusinessAddressRequest)
        {
            return await rc.Put<RingCentral.AccountBusinessAddressResource>(this.Path(),
                modifyAccountBusinessAddressRequest);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public Restapi.Account.BusinessAddress.Index BusinessAddress()
        {
            return new Restapi.Account.BusinessAddress.Index(this);
        }
    }
}