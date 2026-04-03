using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.IvrMenus
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Index parent;
        public string ivrMenuId;
        public Index(Restapi.Account.Index parent, string ivrMenuId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.ivrMenuId = ivrMenuId;
        }
        public string Path(bool withParameter = true)
        {
            if (withParameter && ivrMenuId != null)
            {
                return $"{parent.Path()}/ivr-menus/{ivrMenuId}";
            }
            return $"{parent.Path()}/ivr-menus";
        }
        /// <summary>
        /// Returns a company IVR menus.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/ivr-menus
        /// Rate Limit Group: Medium
        /// App Permission: ReadAccounts
        /// </summary>
        public async Task<RingCentral.IvrMenuList> List(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.IvrMenuList>(this.Path(false), null, restRequestConfig);
        }

        /// <summary>
        /// Creates a company IVR menu.
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/ivr-menus
        /// Rate Limit Group: Heavy
        /// App Permission: EditAccounts
        /// User Permission: AutoReceptionist
        /// </summary>
        public async Task<RingCentral.IvrMenuInfo> Post(RingCentral.IvrMenuInfo ivrMenuInfo, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.IvrMenuInfo>(this.Path(false), ivrMenuInfo, null, restRequestConfig);
        }

        /// <summary>
        /// Returns a company IVR menu by ID.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/ivr-menus/{ivrMenuId}
        /// Rate Limit Group: Medium
        /// App Permission: ReadAccounts
        /// User Permission: AutoReceptionist
        /// </summary>
        public async Task<RingCentral.IvrMenuInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            if (ivrMenuId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(ivrMenuId));
            }
            return await rc.Get<RingCentral.IvrMenuInfo>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Updates a company IVR menu by ID.
        /// HTTP Method: put
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/ivr-menus/{ivrMenuId}
        /// Rate Limit Group: Medium
        /// App Permission: ReadAccounts
        /// User Permission: AutoReceptionist
        /// </summary>
        public async Task<RingCentral.IvrMenuInfo> Put(RingCentral.IvrMenuInfo ivrMenuInfo, RestRequestConfig restRequestConfig = null)
        {
            if (ivrMenuId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(ivrMenuId));
            }
            return await rc.Put<RingCentral.IvrMenuInfo>(this.Path(), ivrMenuInfo, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public Restapi.Account.IvrMenus.Index IvrMenus(string ivrMenuId = null)
        {
            return new Restapi.Account.IvrMenus.Index(this, ivrMenuId);
        }
    }
}