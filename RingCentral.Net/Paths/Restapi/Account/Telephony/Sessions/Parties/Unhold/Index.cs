using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Parties.Unhold
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

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/unhold";
        }

        /// <summary>
        ///     Brings a party back into a call and stops to play Hold Music. There is a known limitation for Hold API - hold via
        ///     REST API doesn't work with hold placed via RingCentral apps or HardPhone. It means that if you muted participant
        ///     via Call Control API and RingCentral Desktop app, then you need to un-hold both endpoints to remove Hold Music and
        ///     bring media back.
        ///     HTTP Method: post
        ///     Endpoint:
        ///     /restapi/{apiVersion}/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/unhold
        ///     Rate Limit Group: Light
        ///     App Permission: CallControl
        /// </summary>
        public async Task<CallParty> Post(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<CallParty>(Path(), null, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Parties
{
    public partial class Index
    {
        public Unhold.Index Unhold()
        {
            return new Unhold.Index(this);
        }
    }
}