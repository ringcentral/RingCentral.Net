using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Sites.Members
{
    public class Index
    {
        public Sites.Index parent;
        public RestClient rc;

        public Index(Sites.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/members";
        }

        /// <summary>
        ///     Returns members of a site specified in path.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/sites/{siteId}/members
        ///     Rate Limit Group: Medium
        ///     App Permission: ReadAccounts
        ///     User Permission: ReadExtensions
        /// </summary>
        public async Task<SiteMembersList> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<SiteMembersList>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Sites
{
    public partial class Index
    {
        public Members.Index Members()
        {
            return new Members.Index(this);
        }
    }
}