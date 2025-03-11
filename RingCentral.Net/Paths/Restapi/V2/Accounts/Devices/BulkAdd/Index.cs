using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.V2.Accounts.Devices.BulkAdd
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
            return $"{parent.Path()}/bulk-add";
        }

        /// <summary>
        ///     Adds multiple BYOD (customer provided) devices to an account.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/v2/accounts/{accountId}/devices/bulk-add
        ///     Rate Limit Group: Heavy
        ///     App Permission: EditAccounts
        ///     User Permission: AddRemoveDevices
        /// </summary>
        public async Task<BulkAddDevicesResponse> Post(BulkAddDevicesRequest bulkAddDevicesRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<BulkAddDevicesResponse>(Path(), bulkAddDevicesRequest, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.V2.Accounts.Devices
{
    public partial class Index
    {
        public BulkAdd.Index BulkAdd()
        {
            return new BulkAdd.Index(this);
        }
    }
}