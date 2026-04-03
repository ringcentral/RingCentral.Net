using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.Sites.Members
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
            return $"{parent.Path()}/members";
        }
        /// <summary>
        /// Returns members of a site specified in path.
        /// 
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/sites/{siteId}/members
        /// Rate Limit Group: Medium
        /// App Permission: ReadAccounts
        /// User Permission: ReadExtensions
        /// </summary>
        public async Task<RingCentral.SiteMembersList> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.SiteMembersList>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Sites
{
    public partial class Index
    {
        public Restapi.Account.Sites.Members.Index Members()
        {
            return new Restapi.Account.Sites.Members.Index(this);
        }
    }
}