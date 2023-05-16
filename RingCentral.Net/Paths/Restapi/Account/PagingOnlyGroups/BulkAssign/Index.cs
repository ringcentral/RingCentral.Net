using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.PagingOnlyGroups.BulkAssign
{
    public class Index
    {
        public PagingOnlyGroups.Index parent;
        public RestClient rc;

        public Index(PagingOnlyGroups.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/bulk-assign";
        }

        /// <summary>
        ///     Adds and/or removes paging group users and devices.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/paging-only-groups/{pagingOnlyGroupId}/bulk-assign
        ///     Rate Limit Group: Heavy
        ///     App Permission: EditAccounts
        ///     User Permission: Groups
        /// </summary>
        public async Task<string> Post(EditPagingGroupRequest editPagingGroupRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<string>(Path(), editPagingGroupRequest, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.PagingOnlyGroups
{
    public partial class Index
    {
        public BulkAssign.Index BulkAssign()
        {
            return new BulkAssign.Index(this);
        }
    }
}