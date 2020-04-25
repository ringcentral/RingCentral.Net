using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Account.EmergencyAddressAutoUpdate.Devices.BulkAssign
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.EmergencyAddressAutoUpdate.Devices.Index parent;

        public Index(Restapi.Account.EmergencyAddressAutoUpdate.Devices.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/bulk-assign";
        }

        /// <summary>
        /// Operation: Enable Automatic Location Updates for Devices
        /// Rate Limit Group: Heavy
        /// Http Post /restapi/v1.0/account/{accountId}/emergency-address-auto-update/devices/bulk-assign
        /// </summary>
        public async Task<string> Post(
            RingCentral.AssignMultipleDevicesAutomaticLocationUpdates assignMultipleDevicesAutomaticLocationUpdates,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Post<string>(this.Path(), assignMultipleDevicesAutomaticLocationUpdates, null,
                cancellationToken);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.EmergencyAddressAutoUpdate.Devices
{
    public partial class Index
    {
        public Restapi.Account.EmergencyAddressAutoUpdate.Devices.BulkAssign.Index BulkAssign()
        {
            return new Restapi.Account.EmergencyAddressAutoUpdate.Devices.BulkAssign.Index(this);
        }
    }
}