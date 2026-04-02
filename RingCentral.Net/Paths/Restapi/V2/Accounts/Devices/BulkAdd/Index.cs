using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.V2.Accounts.Devices.BulkAdd
{
    public partial class Index
    {
        public RestClient rc;
public Restapi.V2.Accounts.Devices.Index parent;
public Index(Restapi.V2.Accounts.Devices.Index parent)
      {
this.parent = parent;
this.rc = parent.rc;
}
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/bulk-add";
        }
        /// <summary>
        /// Adds multiple BYOD (customer provided) devices to an account.
        /// HTTP Method: post
        /// Endpoint: /restapi/v2/accounts/{accountId}/devices/bulk-add
        /// Rate Limit Group: Heavy
        /// App Permission: EditAccounts
        /// User Permission: AddRemoveDevices
        /// </summary>
  public async Task<RingCentral.BulkAddDevicesResponse> Post(RingCentral.BulkAddDevicesRequest bulkAddDevicesRequest, RestRequestConfig restRequestConfig = null)
  {
return await rc.Post<RingCentral.BulkAddDevicesResponse>(this.Path(), bulkAddDevicesRequest, null, restRequestConfig);
  }
    }
}

namespace RingCentral.Paths.Restapi.V2.Accounts.Devices
{
    public partial class Index
    {
        public Restapi.V2.Accounts.Devices.BulkAdd.Index BulkAdd()
        {
            return new Restapi.V2.Accounts.Devices.BulkAdd.Index(this);
        }
    }
}