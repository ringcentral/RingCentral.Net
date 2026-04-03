using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.V2.Accounts.Extensions.Devices
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.V2.Accounts.Extensions.Index parent;
        public string deviceId;
        public Index(Restapi.V2.Accounts.Extensions.Index parent, string deviceId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.deviceId = deviceId;
        }
        public string Path(bool withParameter = true)
        {
            if (withParameter && deviceId != null)
            {
                return $"{parent.Path()}/devices/{deviceId}";
            }
            return $"{parent.Path()}/devices";
        }

    }
}

namespace RingCentral.Paths.Restapi.V2.Accounts.Extensions
{
    public partial class Index
    {
        public Restapi.V2.Accounts.Extensions.Devices.Index Devices(string deviceId = null)
        {
            return new Restapi.V2.Accounts.Extensions.Devices.Index(this, deviceId);
        }
    }
}