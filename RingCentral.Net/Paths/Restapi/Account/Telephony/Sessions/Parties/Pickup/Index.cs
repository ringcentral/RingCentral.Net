using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Parties.Pickup
{
    public class Index
    {
        public Parties.Index parent;
        public RestClient rc;

        public Index(Parties.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/pickup";
        }

        /// <summary>
        ///     Picks up a call parked to the specified park location.
        ///     HTTP Method: post
        ///     Endpoint:
        ///     /restapi/{apiVersion}/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/pickup
        ///     Rate Limit Group: Light
        ///     App Permission: CallControl
        /// </summary>
        public async Task<CallParty> Post(PickupTarget pickupTarget,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<CallParty>(Path(), pickupTarget, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Parties
{
    public partial class Index
    {
        public Pickup.Index Pickup()
        {
            return new Pickup.Index(this);
        }
    }
}