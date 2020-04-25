using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Parties.Reply
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
            return $"{parent.Path()}/reply";
        }

        /// <summary>
        /// Operation: Reply with Text
        /// Http Post /restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/reply
        /// </summary>
        public async Task<RingCentral.ReplyParty> Post(RingCentral.CallPartyReply callPartyReply,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Post<RingCentral.ReplyParty>(this.Path(), callPartyReply, null, cancellationToken);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Parties
{
    public partial class Index
    {
        public Restapi.Account.Telephony.Sessions.Parties.Reply.Index Reply()
        {
            return new Restapi.Account.Telephony.Sessions.Parties.Reply.Index(this);
        }
    }
}