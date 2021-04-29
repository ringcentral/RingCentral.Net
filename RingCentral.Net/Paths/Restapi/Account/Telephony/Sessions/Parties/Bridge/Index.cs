using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

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
        /// Allows the user to connect multiple call session participants over a conference call bridge. The current active call session ID and party ID of the user within this session should be specified in path; the bridged call session ID and party ID of the user within that session should be specified in request body. Thus the user connects participants of two sessions into one conference call using his/her own party IDs from both sessions.
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/bridge
        /// Rate Limit Group: Light
        /// App Permission: CallControl
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