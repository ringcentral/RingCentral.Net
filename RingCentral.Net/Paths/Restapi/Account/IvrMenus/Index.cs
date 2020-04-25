using System.Threading.Tasks;
using System.Threading;

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
        /// App Permission Required: EditAccounts
        /// User Permission Required: AutoReceptionist
        /// </summary>
        public async Task<RingCentral.IVRMenuInfo> Post(RingCentral.IVRMenuInfo iVRMenuInfo,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Post<RingCentral.IVRMenuInfo>(this.Path(false), iVRMenuInfo, null, cancellationToken);
        }

        /// <summary>
        /// Operation: Get IVR Menu
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/ivr-menus/{ivrMenuId}
        /// Rate Limit Group: Medium
        /// App Permission Required: ReadAccounts
        /// User Permission Required: AutoReceptionist
        /// </summary>
        public async Task<RingCentral.IVRMenuInfo> Get(CancellationToken? cancellationToken = null)
        {
            if (this.ivrMenuId == null)
            {
                throw new System.ArgumentNullException("ivrMenuId");
            }

            return await rc.Get<RingCentral.IVRMenuInfo>(this.Path(), null, cancellationToken);
        }

        /// <summary>
        /// Operation: Update IVR Menu
        /// HTTP Method: PUT
        /// Endpoint: /restapi/v1.0/account/{accountId}/ivr-menus/{ivrMenuId}
        /// Rate Limit Group: Medium
        /// App Permission Required: ReadAccounts
        /// User Permission Required: AutoReceptionist
        /// </summary>
        public async Task<RingCentral.IVRMenuInfo> Put(RingCentral.IVRMenuInfo iVRMenuInfo,
            CancellationToken? cancellationToken = null)
        {
            if (this.ivrMenuId == null)
            {
                throw new System.ArgumentNullException("ivrMenuId");
            }

            return await rc.Put<RingCentral.IVRMenuInfo>(this.Path(), iVRMenuInfo, null, cancellationToken);
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