using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.IvrMenus
{
    public class Index
    {
        public string ivrMenuId;
        public Account.Index parent;
        public RestClient rc;

        public Index(Account.Index parent, string ivrMenuId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.ivrMenuId = ivrMenuId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && ivrMenuId != null) return $"{parent.Path()}/ivr-menus/{ivrMenuId}";

            return $"{parent.Path()}/ivr-menus";
        }

        /// <summary>
        ///     Returns a company IVR menus.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/ivr-menus
        ///     Rate Limit Group: Medium
        ///     App Permission: ReadAccounts
        /// </summary>
        public async Task<IVRMenuList> List(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<IVRMenuList>(Path(false), null, restRequestConfig);
        }

        /// <summary>
        ///     Creates a company IVR menu.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/ivr-menus
        ///     Rate Limit Group: Heavy
        ///     App Permission: EditAccounts
        ///     User Permission: AutoReceptionist
        /// </summary>
        public async Task<IVRMenuInfo> Post(IVRMenuInfo iVRMenuInfo,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<IVRMenuInfo>(Path(false), iVRMenuInfo, null, restRequestConfig);
        }

        /// <summary>
        ///     Returns a company IVR menu by ID.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/ivr-menus/{ivrMenuId}
        ///     Rate Limit Group: Medium
        ///     App Permission: ReadAccounts
        ///     User Permission: AutoReceptionist
        /// </summary>
        public async Task<IVRMenuInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            if (ivrMenuId == null) throw new ArgumentException("Parameter cannot be null", nameof(ivrMenuId));

            return await rc.Get<IVRMenuInfo>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Updates a company IVR menu by ID.
        ///     HTTP Method: put
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/ivr-menus/{ivrMenuId}
        ///     Rate Limit Group: Medium
        ///     App Permission: ReadAccounts
        ///     User Permission: AutoReceptionist
        /// </summary>
        public async Task<IVRMenuInfo> Put(IVRMenuInfo iVRMenuInfo,
            RestRequestConfig restRequestConfig = null)
        {
            if (ivrMenuId == null) throw new ArgumentException("Parameter cannot be null", nameof(ivrMenuId));

            return await rc.Put<IVRMenuInfo>(Path(), iVRMenuInfo, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public IvrMenus.Index IvrMenus(string ivrMenuId = null)
        {
            return new IvrMenus.Index(this, ivrMenuId);
        }
    }
}