using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.PagingOnlyGroups.Users
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
            return $"{parent.Path()}/users";
        }

        /// <summary>
        ///     Returns a list of users allowed to page this group.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/paging-only-groups/{pagingOnlyGroupId}/users
        ///     Rate Limit Group: Light
        ///     App Permission: ReadAccounts
        ///     User Permission: ReadUserInfo
        /// </summary>
        public async Task<PagingOnlyGroupUsers> Get(ListPagingGroupUsersParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<PagingOnlyGroupUsers>(Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.PagingOnlyGroups
{
    public partial class Index
    {
        public Users.Index Users()
        {
            return new Users.Index(this);
        }
    }
}