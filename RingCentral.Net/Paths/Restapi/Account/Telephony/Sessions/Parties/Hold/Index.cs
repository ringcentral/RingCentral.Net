using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Parties.Hold
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
            return $"{parent.Path()}/hold";
        }

        /// <summary>
        ///     Puts the party to stand-alone mode and starts to play Hold Music according to configuration & state to peers. There
        ///     is a known limitation for Hold API - hold via REST API doesn't work with hold placed via RingCentral apps or
        ///     HardPhone. It means that if you muted participant via Call Control API and RingCentral Desktop app, then you need
        ///     to unhold both endpoints to remove Hold Music and bring media back.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/hold
        ///     Rate Limit Group: Light
        ///     App Permission: CallControl
        /// </summary>
        public async Task<CallParty> Post(HoldCallPartyRequest holdCallPartyRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<CallParty>(Path(), holdCallPartyRequest, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Parties
{
    public partial class Index
    {
        public Hold.Index Hold()
        {
            return new Hold.Index(this);
        }
    }
}