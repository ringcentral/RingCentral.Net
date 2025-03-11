using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Presence
{
    public class Index
    {
        public Account.Index parent;
        public RestClient rc;

        public Index(Account.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/presence";
        }

        /// <summary>
        ///     Returns presence status of all extensions of an account. Please note: The presenceStatus is returned as Offline
        ///     (the parameters telephonyStatus, message, userStatus and dndStatus are not returned at all) for the following
        ///     extension types: Department, Announcement Only, Voicemail (Take Messages Only), Fax User, Paging Only Group, Shared
        ///     Lines Group, IVR Menu, Application Extension.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/presence
        ///     Rate Limit Group: Heavy
        ///     App Permission: ReadPresence
        ///     User Permission: ReadPresenceStatus
        /// </summary>
        public async Task<AccountPresenceInfo> Get(ReadAccountPresenceParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<AccountPresenceInfo>(Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public Presence.Index Presence()
        {
            return new Presence.Index(this);
        }
    }
}