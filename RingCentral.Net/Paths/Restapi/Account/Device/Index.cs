using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Device
{
    public partial class Index
    {
        public RestClient rc;
        public string deviceId;
        public Restapi.Account.Index parent;

        public Index(Restapi.Account.Index parent, string deviceId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.deviceId = deviceId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && deviceId != null)
            {
                return $"{parent.Path()}/device/{deviceId}";
            }

            return $"{parent.Path()}/device";
        }

        // Operation: loadAccountDevice
        // Http Get /restapi/v1.0/account/{accountId}/device/{deviceId}
        public async Task<RingCentral.GetDeviceInfoResponse> Get()
        {
            if (this.deviceId == null)
            {
                throw new System.ArgumentNullException("deviceId");
            }

            return await rc.Get<RingCentral.GetDeviceInfoResponse>(this.Path());
        }

        // Operation: updateDevice
        // Http Put /restapi/v1.0/account/{accountId}/device/{deviceId}
        public async Task<RingCentral.DeviceResource> Put(RingCentral.AccountDeviceUpdate accountDeviceUpdate)
        {
            if (this.deviceId == null)
            {
                throw new System.ArgumentNullException("deviceId");
            }

            return await rc.Put<RingCentral.DeviceResource>(this.Path(), accountDeviceUpdate);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public Restapi.Account.Device.Index Device(string deviceId = null)
        {
            return new Restapi.Account.Device.Index(this, deviceId);
        }
    }
}