namespace RingCentral.Paths.Restapi.V2.Accounts.Extensions.Devices
{
    public partial class Index
    {
        public string deviceId;
        public Extensions.Index parent;
        public RestClient rc;

        public Index(Extensions.Index parent, string deviceId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.deviceId = deviceId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && deviceId != null) return $"{parent.Path()}/devices/{deviceId}";
            return $"{parent.Path()}/devices";
        }
    }
}

namespace RingCentral.Paths.Restapi.V2.Accounts.Extensions
{
    public partial class Index
    {
        public Devices.Index Devices(string deviceId = null)
        {
            return new Devices.Index(this, deviceId);
        }
    }
}