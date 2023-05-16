using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.V2.Accounts.Licenses.BulkAssign
{
    public class Index
    {
        public Licenses.Index parent;
        public RestClient rc;

        public Index(Licenses.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/bulk-assign";
        }

        /// <summary>
        ///     Assigns/unassigns multiple account licenses in bulk
        ///     HTTP Method: post
        ///     Endpoint: /restapi/v2/accounts/{accountId}/licenses/bulk-assign
        ///     Rate Limit Group: Heavy
        ///     App Permission: EditAccounts
        /// </summary>
        public async Task<BulkManageLicensesResponse> Post(BulkManageLicensesRequest bulkManageLicensesRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<BulkManageLicensesResponse>(Path(), bulkManageLicensesRequest, null,
                restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.V2.Accounts.Licenses
{
    public partial class Index
    {
        public BulkAssign.Index BulkAssign()
        {
            return new BulkAssign.Index(this);
        }
    }
}