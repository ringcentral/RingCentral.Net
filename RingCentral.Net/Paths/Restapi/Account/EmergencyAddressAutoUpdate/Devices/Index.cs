using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

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
        /// Returns the list of common devices with their status of Automatic Location Updates feature.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/devices
        /// Rate Limit Group: Medium
        /// App Permission: EditAccounts
        /// User Permission: ConfigureEmergencyMaps
        /// </summary>
        public async Task<RingCentral.ListDevicesAutomaticLocationUpdates> Get(
            RingCentral.ListDevicesAutomaticLocationUpdatesParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.ListDevicesAutomaticLocationUpdates>(this.Path(), queryParams,
                restRequestConfig);
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