using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Account.PagingOnlyGroups.Users
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
            return $"{parent.Path()}/users";
        }

        /// <summary>
        /// Operation: Get Paging Group Users
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/paging-only-groups/{pagingOnlyGroupId}/users
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// User Permission: ReadUserInfo
        /// </summary>
        public async Task<RingCentral.PagingOnlyGroupUsers> Get(ListPagingGroupUsersParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.PagingOnlyGroupUsers>(this.Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.PagingOnlyGroups
{
    public partial class Index
    {
        public Restapi.Account.PagingOnlyGroups.Users.Index Users()
        {
            return new Restapi.Account.PagingOnlyGroups.Users.Index(this);
        }
    }
}