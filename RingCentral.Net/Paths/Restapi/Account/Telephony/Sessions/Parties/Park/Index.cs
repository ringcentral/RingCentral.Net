using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Parties.Park
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
            return $"{parent.Path()}/park";
        }

        /// <summary>
        ///     Parks a call to a virtual location from where it can further be retrieved by any user from any phone of the system.
        ///     The call session and call party identifiers should be specified in path. Currently the users can park only their
        ///     own incoming calls. Up to 50 calls can be parked simultaneously. Park location starts with asterisk (*) and ranges
        ///     801-899.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/park
        ///     Rate Limit Group: Light
        ///     App Permission: CallControl
        /// </summary>
        public async Task<CallParty> Post(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<CallParty>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Parties
{
    public partial class Index
    {
        public Park.Index Park()
        {
            return new Park.Index(this);
        }
    }
}