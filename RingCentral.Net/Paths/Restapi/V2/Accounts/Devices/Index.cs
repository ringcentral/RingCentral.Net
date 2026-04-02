using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.V2.Accounts.Devices
{
    public partial class Index
    {
        public RestClient rc;
public Restapi.V2.Accounts.Index parent;
public string deviceId;
public Index(Restapi.V2.Accounts.Index parent, string deviceId = null)
      {
this.parent = parent;
this.rc = parent.rc;
this.deviceId = deviceId;
}
        public string Path(bool withParameter = true)
        {
            if (withParameter && deviceId != null)
            {
                return $"{parent.Path()}/devices/{deviceId}";
            }
            return $"{parent.Path()}/devices";
        }
        /// <summary>
        /// Disassociates a phone line (DL & Device) from an extension:
/// 
///  - if the value of `keepAssetsInInventory` is `true`,
/// the given device is moved to unassigned devices and the number is moved to the number inventory;
///  - if the value of `keepAssetsInInventory` is `false`, the given device and number is removed from the account;
///  - if the parameter `keepAssetsInInventory` is not set (empty body), default value `true` is set.
/// 
        /// HTTP Method: delete
        /// Endpoint: /restapi/v2/accounts/{accountId}/devices/{deviceId}
        /// Rate Limit Group: Medium
        /// App Permission: EditAccounts
        /// User Permission: EditAccountDevices
        /// </summary>
  public async Task<RingCentral.RemoveLineResponse> Delete(RingCentral.RemoveLineRequest removeLineRequest, RestRequestConfig restRequestConfig = null)
  {
if (deviceId == null)
    {
        throw new System.ArgumentException("Parameter cannot be null", nameof(deviceId));
    }return await rc.Delete<RingCentral.RemoveLineResponse>(this.Path(), removeLineRequest, null, restRequestConfig);
  }
    }
}

namespace RingCentral.Paths.Restapi.V2.Accounts
{
    public partial class Index
    {
        public Restapi.V2.Accounts.Devices.Index Devices(string deviceId = null)
        {
            return new Restapi.V2.Accounts.Devices.Index(this, deviceId);
        }
    }
}