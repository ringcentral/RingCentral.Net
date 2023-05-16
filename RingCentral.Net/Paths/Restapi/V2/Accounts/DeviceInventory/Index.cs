using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.V2.Accounts.DeviceInventory
{
    public class Index
    {
        public Accounts.Index parent;
        public RestClient rc;

        public Index(Accounts.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/device-inventory";
        }

        /// <summary>
        ///     Adds an existing phone (customer provided device - BYOD) as an unassigned device to the account inventory.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/v2/accounts/{accountId}/device-inventory
        ///     Rate Limit Group: Heavy
        ///     App Permission: EditAccounts
        /// </summary>
        public async Task<AddDeviceToInventoryResponse> Post(AddDeviceToInventoryRequest addDeviceToInventoryRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<AddDeviceToInventoryResponse>(Path(), addDeviceToInventoryRequest, null,
                restRequestConfig);
        }

        /// <summary>
        ///     Deletes an existing unassigned (without digital line or phone number) device or multiple devices
        ///     from the account inventory. It is possible to delete up to 10 devices per request.
        ///     HTTP Method: delete
        ///     Endpoint: /restapi/v2/accounts/{accountId}/device-inventory
        ///     Rate Limit Group: Heavy
        ///     App Permission: EditAccounts
        /// </summary>
        public async Task<DeleteDeviceFromInventoryResponse> Delete(
            DeleteDeviceFromInventoryRequest deleteDeviceFromInventoryRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Delete<DeleteDeviceFromInventoryResponse>(Path(), deleteDeviceFromInventoryRequest, null,
                restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.V2.Accounts
{
    public partial class Index
    {
        public DeviceInventory.Index DeviceInventory()
        {
            return new DeviceInventory.Index(this);
        }
    }
}