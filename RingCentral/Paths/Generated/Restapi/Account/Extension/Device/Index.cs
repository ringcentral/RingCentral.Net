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

        public async Task<RingCentral.GetExtensionDevicesResponse> Get(GetQueryParams queryParams = null)
        {
            return await rc.Get<RingCentral.GetExtensionDevicesResponse>(this.Path(), queryParams);
        }

        public async Task<RingCentral.GetExtensionDevicesResponse> Get(object queryParams)
        {
            return await rc.Get<RingCentral.GetExtensionDevicesResponse>(this.Path(), queryParams);
        }
    }

    public class GetQueryParams
    {
        // Pooling type of a device
        // Enum: Host, Guest, None
        public string linePooling;

        // Device feature or multiple features supported
        // Enum: Intercom, Paging, BLA
        public string feature;
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