using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.EmergencyAddressAutoUpdate.Devices
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.EmergencyAddressAutoUpdate.Index parent;

        public Index(Restapi.Account.EmergencyAddressAutoUpdate.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/devices";
        }

        /// <summary>
        /// Operation: Get Device List
        /// Http Get /restapi/v1.0/account/{accountId}/emergency-address-auto-update/devices
        /// </summary>
        public async Task<RingCentral.ListDevicesAutomaticLocationUpdates> Get(
            ListDevicesAutomaticLocationUpdatesParameters queryParams = null)
        {
            return await rc.Get<RingCentral.ListDevicesAutomaticLocationUpdates>(this.Path(), queryParams);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.EmergencyAddressAutoUpdate
{
    public partial class Index
    {
        public Restapi.Account.EmergencyAddressAutoUpdate.Devices.Index Devices()
        {
            return new Restapi.Account.EmergencyAddressAutoUpdate.Devices.Index(this);
        }
    }
}