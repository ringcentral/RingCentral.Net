using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.EmergencyAddressAutoUpdate.Devices.BulkAssign
{
    public class Index
    {
        public Devices.Index parent;
        public RestClient rc;

        public Index(Devices.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/bulk-assign";
        }

        /// <summary>
        ///     Enables or disables Automatic Location Updates feature for the
        ///     specified common phones.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/devices/bulk-assign
        ///     Rate Limit Group: Heavy
        ///     App Permission: EditAccounts
        ///     User Permission: ConfigureEmergencyMaps
        /// </summary>
        public async Task<string> Post(
            AssignMultipleDevicesAutomaticLocationUpdates assignMultipleDevicesAutomaticLocationUpdates,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<string>(Path(), assignMultipleDevicesAutomaticLocationUpdates, null,
                restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.EmergencyAddressAutoUpdate.Devices
{
    public partial class Index
    {
        public BulkAssign.Index BulkAssign()
        {
            return new BulkAssign.Index(this);
        }
    }
}