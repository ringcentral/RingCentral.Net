using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.V2.Accounts.Extensions
{
    public partial class Index
    {
        public RestClient rc;
public Restapi.V2.Accounts.Index parent;
public string extensionId;
public Index(Restapi.V2.Accounts.Index parent, string extensionId = "~")
      {
this.parent = parent;
this.rc = parent.rc;
this.extensionId = extensionId;
}
        public string Path(bool withParameter = true)
        {
            if (withParameter && extensionId != null)
            {
                return $"{parent.Path()}/extensions/{extensionId}";
            }
            return $"{parent.Path()}/extensions";
        }
        /// <summary>
        /// Deletes extension(s) of User and Limited types, and depending on device type either keeps or destroys
/// the assets - numbers and devices. If a device is rented or bought in RC, it will be moved to the inventory.
/// A BYOD (Other Phone) device will be deleted. Multiple extensions can be deleted by a single API call.
/// 
        /// HTTP Method: delete
        /// Endpoint: /restapi/v2/accounts/{accountId}/extensions
        /// Rate Limit Group: Heavy
        /// App Permission: EditAccounts
        /// User Permission: Users
        /// </summary>
  public async Task<RingCentral.BulkDeleteUsersResponse> Delete(RingCentral.BulkDeleteUsersRequest bulkDeleteUsersRequest, RestRequestConfig restRequestConfig = null)
  {
return await rc.Delete<RingCentral.BulkDeleteUsersResponse>(this.Path(false), bulkDeleteUsersRequest, null, restRequestConfig);
  }
    }
}

namespace RingCentral.Paths.Restapi.V2.Accounts
{
    public partial class Index
    {
        public Restapi.V2.Accounts.Extensions.Index Extensions(string extensionId = "~")
        {
            return new Restapi.V2.Accounts.Extensions.Index(this, extensionId);
        }
    }
}