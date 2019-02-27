using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Parties.Unhold
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Telephony.Sessions.Parties.Index parent;

        public Index(Restapi.Account.Telephony.Sessions.Parties.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/unhold";
        }

        // Operation: unholdCallParty
        // Http Post /restapi/v1.0/account/{accountId}/telephony/sessions/{sessionId}/parties/{partyId}/unhold
        public async Task<RingCentral.CallParty> Post()
        {
            return await rc.Post<RingCentral.CallParty>(this.Path());
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Parties
{
    public partial class Index
    {
        public Restapi.Account.Telephony.Sessions.Parties.Unhold.Index Unhold()
        {
            return new Restapi.Account.Telephony.Sessions.Parties.Unhold.Index(this);
        }
    }
}