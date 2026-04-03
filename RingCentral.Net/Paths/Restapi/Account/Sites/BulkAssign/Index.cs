using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.Sites.BulkAssign
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Sites.Index parent;
        public Index(Restapi.Account.Sites.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/bulk-assign";
        }
        /// <summary>
        /// Assigns multiple sites to an account specified in path.
        /// 
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/sites/{siteId}/bulk-assign
        /// Rate Limit Group: Medium
        /// App Permission: EditExtensions
        /// User Permission: Sites
        /// </summary>
        public async Task<string> Post(RingCentral.SiteMembersBulkUpdate siteMembersBulkUpdate, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<string>(this.Path(), siteMembersBulkUpdate, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Sites
{
    public partial class Index
    {
        public Restapi.Account.Sites.BulkAssign.Index BulkAssign()
        {
            return new Restapi.Account.Sites.BulkAssign.Index(this);
        }
    }
}