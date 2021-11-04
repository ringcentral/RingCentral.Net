using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Parties.Forward
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
            return $"{parent.Path()}/forward";
        }

        /// <summary>
        ///     Forwards a non-answered incoming call to the specified call party. Applicable for a call session in "Setup" or
        ///     "Proceeding" state.
        ///     HTTP Method: post
        ///     Endpoint:
        ///     /restapi/{apiVersion}/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/forward
        ///     Rate Limit Group: Light
        ///     App Permission: CallControl
        /// </summary>
        public async Task<CallParty> Post(ForwardTarget forwardTarget,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<CallParty>(Path(), forwardTarget, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Parties
{
    public partial class Index
    {
        public Forward.Index Forward()
        {
            return new Forward.Index(this);
        }
    }
}