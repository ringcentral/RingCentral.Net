using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Parties.Park
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
            return $"{parent.Path()}/park";
        }

        /// <summary>
        /// Operation: Call Park
        /// Rate Limit Group: Light
        /// Http Post /restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/park
        /// </summary>
        public async Task<RingCentral.CallParty> Post(CancellationToken? cancellationToken = null)
        {
            return await rc.Post<RingCentral.CallParty>(this.Path(), null, cancellationToken);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Parties
{
    public partial class Index
    {
        public Restapi.Account.Telephony.Sessions.Parties.Park.Index Park()
        {
            return new Restapi.Account.Telephony.Sessions.Parties.Park.Index(this);
        }
    }
}