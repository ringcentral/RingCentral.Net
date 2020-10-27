using System.Threading.Tasks;

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
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/pickup
        /// Rate Limit Group: Light
        /// App Permission: CallControl
        /// User Permission: undefined
        /// </summary>
        public async Task<RingCentral.CallParty> Post(RingCentral.PickupTarget pickupTarget,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.CallParty>(this.Path(), pickupTarget, null, restRequestConfig);
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