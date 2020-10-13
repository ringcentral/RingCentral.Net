using System.Threading.Tasks;
using System.Threading;

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

        public string Path()
        {
            return $"{parent.Path()}/presence";
        }

        /// <summary>
        /// Operation: Get User Presence Status List
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/presence
        /// Rate Limit Group: Heavy
        /// App Permission: ReadPresence
        /// User Permission: ReadPresenceStatus
        /// </summary>
        public async Task<RingCentral.AccountPresenceInfo> Get(ReadAccountPresenceParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
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