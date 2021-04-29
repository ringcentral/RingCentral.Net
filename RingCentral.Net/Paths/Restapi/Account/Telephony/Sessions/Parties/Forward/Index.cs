using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

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
        /// Forwards a non-answered incoming call to the specified call party. Applicable for a call session in "Setup" or "Proceeding" state.
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/forward
        /// Rate Limit Group: Light
        /// App Permission: CallControl
        /// </summary>
        public async Task<RingCentral.CallParty> Post(RingCentral.ForwardTarget forwardTarget,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.CallParty>(this.Path(), forwardTarget, null, restRequestConfig);
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