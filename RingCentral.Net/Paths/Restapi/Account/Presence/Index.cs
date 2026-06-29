using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.Presence
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Index parent;
        public Index(Restapi.Account.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/presence";
        }
        /// <summary>
        /// Returns the presence status of all extensions of an account.
        /// 
        /// Note: for the extension types listed below, `presenceStatus` is always returned
        /// as `Offline`, and the `telephonyStatus`, `message`, `userStatus`, and `dndStatus`
        /// attributes are not returned at all:
        /// 
        /// - Department
        /// - Announcement Only
        /// - Voicemail (Take Messages Only)
        /// - Fax User
        /// - Paging Only Group
        /// - Shared Lines Group
        /// - IVR Menu
        /// - Application Extension
        /// 
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/presence
        /// Rate Limit Group: Heavy
        /// App Permission: ReadPresence
        /// User Permission: ReadPresenceStatus
        /// </summary>
        public async Task<RingCentral.AccountPresenceInfo> Get(RingCentral.ReadAccountPresenceParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.AccountPresenceInfo>(this.Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public Restapi.Account.Presence.Index Presence()
        {
            return new Restapi.Account.Presence.Index(this);
        }
    }
}