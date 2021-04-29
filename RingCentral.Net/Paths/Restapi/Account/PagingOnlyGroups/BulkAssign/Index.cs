using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

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
        /// Adds and/or removes paging group users and devices.
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/paging-only-groups/{pagingOnlyGroupId}/bulk-assign
        /// Rate Limit Group: Heavy
        /// App Permission: EditAccounts
        /// User Permission: Groups
        /// </summary>
        public async Task<string> Post(RingCentral.EditPagingGroupRequest editPagingGroupRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<string>(this.Path(), editPagingGroupRequest, null, restRequestConfig);
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