using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.Device
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
            return $"{parent.Path()}/device";
        }

        public async Task<RingCentral.GetExtensionDevicesResponse> Get()
        {
            return await rc.Get<RingCentral.GetExtensionDevicesResponse>(this.Path());
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.Device.Index Device()
        {
            return new Restapi.Account.Extension.Device.Index(this);
        }
    }
}