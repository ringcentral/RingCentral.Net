using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.V2.Accounts.Devices
{
    public partial class Index
    {
        public string deviceId;
        public Accounts.Index parent;
        public RestClient rc;

        public Index(Accounts.Index parent, string deviceId = null)
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

        /// <summary>
        ///     Disassociates a phone line (DL & Device) from an extension:
        ///     - if the value of `keepAssetsInInventory` is `true`,
        ///     the given device is moved to unassigned devices and the number is moved to the number inventory;
        ///     - if the value of `keepAssetsInInventory` is `false`, the given device and number is removed from the account;
        ///     - if the parameter `keepAssetsInInventory` is not set (empty body), default value `true` is set.
        ///     HTTP Method: delete
        ///     Endpoint: /restapi/v2/accounts/{accountId}/devices/{deviceId}
        ///     Rate Limit Group: Medium
        ///     App Permission: EditAccounts
        ///     User Permission: EditAccountDevices
        /// </summary>
        public async Task<RemoveLineResponse> Delete(RemoveLineRequest removeLineRequest,
            RestRequestConfig restRequestConfig = null)
        {
            if (deviceId == null) throw new ArgumentException("Parameter cannot be null", nameof(deviceId));
            return await rc.Delete<RemoveLineResponse>(Path(), removeLineRequest, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.V2.Accounts
{
    public partial class Index
    {
        public Devices.Index Devices(string deviceId = null)
        {
            return new Devices.Index(this, deviceId);
        }
    }
}