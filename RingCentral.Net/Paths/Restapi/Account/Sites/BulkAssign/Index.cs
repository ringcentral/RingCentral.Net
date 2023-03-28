using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Sites.BulkAssign
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

        public string Path()
        {
            return $"{parent.Path()}/bulk-assign";
        }

        /// <summary>
        ///     Assigns multiple sites to an account specified in path.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/sites/{siteId}/bulk-assign
        ///     Rate Limit Group: Medium
        ///     App Permission: EditExtensions
        ///     User Permission: Sites
        /// </summary>
        public async Task<string> Post(SiteMembersBulkUpdate siteMembersBulkUpdate,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<string>(Path(), siteMembersBulkUpdate, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Sites
{
    public partial class Index
    {
        public BulkAssign.Index BulkAssign()
        {
            return new BulkAssign.Index(this);
        }
    }
}