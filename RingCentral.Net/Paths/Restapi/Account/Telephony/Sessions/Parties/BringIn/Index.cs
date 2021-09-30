using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Parties.BringIn
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
            return $"{parent.Path()}/bring-in";
        }

        /// <summary>
        ///     Adds a new party to the call session by bringing-in an established SIP call connection. The maximum number of
        ///     parties to bring-in is 10; only 1 call party can be added per request. Currently the method is supported for
        ///     sessions of 'Conference' origin only.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/bring-in
        ///     Rate Limit Group: Light
        ///     App Permission: CallControl
        /// </summary>
        public async Task<CallParty> Post(AddPartyRequest addPartyRequest, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<CallParty>(Path(), addPartyRequest, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Parties
{
    public partial class Index
    {
        public BringIn.Index BringIn()
        {
            return new BringIn.Index(this);
        }
    }
}