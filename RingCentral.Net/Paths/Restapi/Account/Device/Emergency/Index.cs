using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.Device.Emergency
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Device.Index parent;
        public Index(Restapi.Account.Device.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/emergency";
        }
        /// <summary>
        /// Updates account device emergency information.
        /// HTTP Method: put
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/device/{deviceId}/emergency
        /// Rate Limit Group: Medium
        /// App Permission: EditAccounts
        /// User Permission: EditCompanyDevices
        /// </summary>
        public async Task<RingCentral.DeviceResource> Put(RingCentral.AccountDeviceUpdate accountDeviceUpdate, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Put<RingCentral.DeviceResource>(this.Path(), accountDeviceUpdate, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Device
{
    public partial class Index
    {
        public Restapi.Account.Device.Emergency.Index Emergency()
        {
            return new Restapi.Account.Device.Emergency.Index(this);
        }
    }
}