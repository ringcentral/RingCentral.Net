using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Parties.Pickup
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
            return $"{parent.Path()}/pickup";
        }

        /// <summary>
        /// Operation: Pickup Call
        /// Http Post /restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/pickup
        /// </summary>
        public async Task<RingCentral.CallParty> Post(RingCentral.PickupTarget pickupTarget,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Post<RingCentral.CallParty>(this.Path(), pickupTarget, null, cancellationToken);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Parties
{
    public partial class Index
    {
        public Restapi.Account.Telephony.Sessions.Parties.Pickup.Index Pickup()
        {
            return new Restapi.Account.Telephony.Sessions.Parties.Pickup.Index(this);
        }
    }
}