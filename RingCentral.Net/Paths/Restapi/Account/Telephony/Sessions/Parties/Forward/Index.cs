using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Parties.Forward
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
            return $"{parent.Path()}/forward";
        }

        /// <summary>
        /// Operation: Forward Call Party
        /// Http Post /restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/forward
        /// </summary>
        public async Task<RingCentral.CallParty> Post(RingCentral.ForwardTarget forwardTarget,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Post<RingCentral.CallParty>(this.Path(), forwardTarget, null, cancellationToken);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Parties
{
    public partial class Index
    {
        public Restapi.Account.Telephony.Sessions.Parties.Forward.Index Forward()
        {
            return new Restapi.Account.Telephony.Sessions.Parties.Forward.Index(this);
        }
    }
}