using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Parties.Reply
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
            return $"{parent.Path()}/reply";
        }

        /// <summary>
        ///     Replies with text/pattern without picking up a call.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/reply
        ///     Rate Limit Group: Light
        ///     App Permission: CallControl
        /// </summary>
        public async Task<ReplyParty> Post(CallPartyReply callPartyReply,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<ReplyParty>(Path(), callPartyReply, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Parties
{
    public partial class Index
    {
        public Reply.Index Reply()
        {
            return new Reply.Index(this);
        }
    }
}