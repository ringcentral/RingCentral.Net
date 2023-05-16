using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Device.Emergency
{
    public class Index
    {
        public Device.Index parent;
        public RestClient rc;

        public Index(Device.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/emergency";
        }

        /// <summary>
        ///     Updates account device emergency information.
        ///     HTTP Method: put
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/device/{deviceId}/emergency
        ///     Rate Limit Group: Medium
        ///     App Permission: EditAccounts
        ///     User Permission: EditCompanyDevices
        /// </summary>
        public async Task<DeviceResource> Put(AccountDeviceUpdate accountDeviceUpdate,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Put<DeviceResource>(Path(), accountDeviceUpdate, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Device
{
    public partial class Index
    {
        public Emergency.Index Emergency()
        {
            return new Emergency.Index(this);
        }
    }
}