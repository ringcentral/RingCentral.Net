using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.V2.Accounts.Extensions
{
    public partial class Index
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
            return $"{parent.Path()}/extensions";
        }

        /// <summary>
        ///     Deletes user extension(s) and either keeps or destroys the assets - numbers and devices.
        ///     Multiple extensions can be deleted with a single API call.
        ///     **Please note:** This API cannot be tested on Sandbox.
        ///     HTTP Method: delete
        ///     Endpoint: /restapi/v2/accounts/{accountId}/extensions
        ///     Rate Limit Group: Heavy
        ///     App Permission: EditAccounts
        ///     User Permission: Users
        /// </summary>
        public async Task<BulkDeleteUsersResponse> Delete(
            BulkDeleteUsersRequest bulkDeleteUsersRequest, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Delete<BulkDeleteUsersResponse>(Path(), bulkDeleteUsersRequest, null,
                restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.V2.Accounts
{
    public partial class Index
    {
        public Extensions.Index Extensions()
        {
            return new Extensions.Index(this);
        }
    }
}