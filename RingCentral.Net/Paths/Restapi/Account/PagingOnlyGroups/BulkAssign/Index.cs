using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Account.PagingOnlyGroups.BulkAssign
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.PagingOnlyGroups.Index parent;

        public Index(Restapi.Account.PagingOnlyGroups.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/bulk-assign";
        }

        /// <summary>
        /// Operation: Assign Paging Group Users and Devices
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/account/{accountId}/paging-only-groups/{pagingOnlyGroupId}/bulk-assign
        /// Rate Limit Group: Heavy
        /// App Permission Required: EditAccounts
        /// User Permission Required: Groups
        /// </summary>
        public async Task<string> Post(RingCentral.EditPagingGroupRequest editPagingGroupRequest,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Post<string>(this.Path(), editPagingGroupRequest, null, cancellationToken);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.PagingOnlyGroups
{
    public partial class Index
    {
        public Restapi.Account.PagingOnlyGroups.BulkAssign.Index BulkAssign()
        {
            return new Restapi.Account.PagingOnlyGroups.BulkAssign.Index(this);
        }
    }
}