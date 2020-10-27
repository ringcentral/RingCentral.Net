using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Parties.Bridge
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
            return $"{parent.Path()}/bridge";
        }

        /// <summary>
        /// Operation: Bridge Call Party
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/bridge
        /// Rate Limit Group: Light
        /// App Permission: CallControl
        /// User Permission: undefined
        /// </summary>
        public async Task<RingCentral.CallParty> Post(RingCentral.BridgeTargetRequest bridgeTargetRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.CallParty>(this.Path(), bridgeTargetRequest, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Parties
{
    public partial class Index
    {
        public Restapi.Account.Telephony.Sessions.Parties.Bridge.Index Bridge()
        {
            return new Restapi.Account.Telephony.Sessions.Parties.Bridge.Index(this);
        }
    }
}