using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.V2.Accounts.DeviceInventory
{
    public partial class Index
    {
        public RestClient rc;
public Restapi.V2.Accounts.Index parent;
public Index(Restapi.V2.Accounts.Index parent)
      {
this.parent = parent;
this.rc = parent.rc;
}
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/device-inventory";
        }
        /// <summary>
        /// Adds an existing phone (customer provided device - BYOD) as an unassigned device to the account inventory.
        /// HTTP Method: post
        /// Endpoint: /restapi/v2/accounts/{accountId}/device-inventory
        /// Rate Limit Group: Heavy
        /// App Permission: EditAccounts
        /// </summary>
  public async Task<RingCentral.AddDeviceToInventoryResponse> Post(RingCentral.AddDeviceToInventoryRequest addDeviceToInventoryRequest, RestRequestConfig restRequestConfig = null)
  {
return await rc.Post<RingCentral.AddDeviceToInventoryResponse>(this.Path(), addDeviceToInventoryRequest, null, restRequestConfig);
  }

        /// <summary>
        /// Deletes an existing unassigned (without digital line or phone number) device or multiple devices
/// from the account inventory. It is possible to delete up to 10 devices per request.
/// 
        /// HTTP Method: delete
        /// Endpoint: /restapi/v2/accounts/{accountId}/device-inventory
        /// Rate Limit Group: Heavy
        /// App Permission: EditAccounts
        /// </summary>
  public async Task<RingCentral.DeleteDeviceFromInventoryResponse> Delete(RingCentral.DeleteDeviceFromInventoryRequest deleteDeviceFromInventoryRequest, RestRequestConfig restRequestConfig = null)
  {
return await rc.Delete<RingCentral.DeleteDeviceFromInventoryResponse>(this.Path(), deleteDeviceFromInventoryRequest, null, restRequestConfig);
  }
    }
}

namespace RingCentral.Paths.Restapi.V2.Accounts
{
    public partial class Index
    {
        public Restapi.V2.Accounts.DeviceInventory.Index DeviceInventory()
        {
            return new Restapi.V2.Accounts.DeviceInventory.Index(this);
        }
    }
}