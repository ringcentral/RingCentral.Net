using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Parties.Bridge
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
            return $"{parent.Path()}/bridge";
        }

        /// <summary>
        ///     Allows the user to connect multiple call session participants over a conference call bridge. The current active
        ///     call session ID and party ID of the user within this session should be specified in path; the bridged call session
        ///     ID and party ID of the user within that session should be specified in request body. Thus the user connects
        ///     participants of two sessions into one conference call using his/her own party IDs from both sessions.
        ///     HTTP Method: post
        ///     Endpoint:
        ///     /restapi/{apiVersion}/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/bridge
        ///     Rate Limit Group: Light
        ///     App Permission: CallControl
        /// </summary>
        public async Task<CallParty> Post(BridgeTargetRequest bridgeTargetRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<CallParty>(Path(), bridgeTargetRequest, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Parties
{
    public partial class Index
    {
        public Bridge.Index Bridge()
        {
            return new Bridge.Index(this);
        }
    }
}