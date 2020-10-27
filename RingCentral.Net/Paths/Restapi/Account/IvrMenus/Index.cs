using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.IvrMenus
{
    public partial class Index
    {
        public RestClient rc;
        public string ivrMenuId;
        public Restapi.Account.Index parent;

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
        /// Operation: Create IVR Menu
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/account/{accountId}/ivr-menus
        /// Rate Limit Group: Heavy
        /// App Permission: EditAccounts
        /// User Permission: AutoReceptionist
        /// </summary>
        public async Task<RingCentral.IVRMenuInfo> Post(RingCentral.IVRMenuInfo iVRMenuInfo,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.IVRMenuInfo>(this.Path(false), iVRMenuInfo, null, restRequestConfig);
        }

        /// <summary>
        /// Operation: Get IVR Menu
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/ivr-menus/{ivrMenuId}
        /// Rate Limit Group: Medium
        /// App Permission: ReadAccounts
        /// User Permission: AutoReceptionist
        /// </summary>
        public async Task<RingCentral.IVRMenuInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            if (this.ivrMenuId == null)
            {
                throw new System.ArgumentNullException("ivrMenuId");
            }

            return await rc.Get<RingCentral.IVRMenuInfo>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Operation: Update IVR Menu
        /// HTTP Method: PUT
        /// Endpoint: /restapi/v1.0/account/{accountId}/ivr-menus/{ivrMenuId}
        /// Rate Limit Group: Medium
        /// App Permission: ReadAccounts
        /// User Permission: AutoReceptionist
        /// </summary>
        public async Task<RingCentral.IVRMenuInfo> Put(RingCentral.IVRMenuInfo iVRMenuInfo,
            RestRequestConfig restRequestConfig = null)
        {
            if (this.ivrMenuId == null)
            {
                throw new System.ArgumentNullException("ivrMenuId");
            }

            return await rc.Put<RingCentral.IVRMenuInfo>(this.Path(), iVRMenuInfo, null, restRequestConfig);
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