using System.Threading.Tasks;

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

        public class GetQueryParams
        {
            // Whether to return detailed telephony state
            public string detailedTelephonyState;

            // Whether to return SIP data
            public string sipData;

            // Page number for account presence information
            public string page;

            // Number for account presence information items per page
            public string perPage;
        }

        public async Task<RingCentral.AccountPresenceInfo> Get(GetQueryParams queryParams = null)
        {
            return await rc.Get<RingCentral.AccountPresenceInfo>(this.Path(), queryParams);
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