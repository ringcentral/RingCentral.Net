using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.V2.Accounts.Extensions.Devices.Replace
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

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/replace";
        }

        /// <summary>
        ///     Replaces the user device with another device, which is assigned to an extension
        ///     or is stored in the inventory of the same account.
        ///     Currently, the following device types can be swapped - `HardPhone` and `OtherPhone`.
        ///     Please note:
        ///     - This method allows replacing a device itself, while a phone number,
        ///     a digital Line and an emergency address associated with this device remain unchanged
        ///     and will still work together in a chain with the replacement device.
        ///     - If a target device is from the inventory, then a source device will be moved
        ///     to the inventory, and a target device will be assigned to the current extension.
        ///     - If a target device is currently assigned to another extension,
        ///     then the devices will be just swapped.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/v2/accounts/{accountId}/extensions/{extensionId}/devices/{deviceId}/replace
        ///     Rate Limit Group: Medium
        ///     App Permission: EditAccounts
        ///     User Permission: EditUserDevices
        /// </summary>
        public async Task<string> Post(SwapDeviceRequest swapDeviceRequest, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<string>(Path(), swapDeviceRequest, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.V2.Accounts.Extensions.Devices
{
    public partial class Index
    {
        public Replace.Index Replace()
        {
            return new Replace.Index(this);
        }
    }
}