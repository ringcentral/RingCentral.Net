using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.EmergencyAddressAutoUpdate.Devices
{
    public partial class Index
    {
        public EmergencyAddressAutoUpdate.Index parent;
        public RestClient rc;

        public Index(EmergencyAddressAutoUpdate.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/devices";
        }

        /// <summary>
        ///     Returns the list of common devices with their status of Automatic Location Updates feature.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/devices
        ///     Rate Limit Group: Medium
        ///     App Permission: EditAccounts
        ///     User Permission: ConfigureEmergencyMaps
        /// </summary>
        public async Task<ListDevicesAutomaticLocationUpdates> Get(
            ListDevicesAutomaticLocationUpdatesParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<ListDevicesAutomaticLocationUpdates>(Path(), queryParams,
                restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.EmergencyAddressAutoUpdate
{
    public partial class Index
    {
        public Devices.Index Devices()
        {
            return new Devices.Index(this);
        }
    }
}