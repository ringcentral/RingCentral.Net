using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Parties.Flip
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
            return $"{parent.Path()}/flip";
        }

        /// <summary>
        /// Operation: Call Flip on Party
        /// Rate Limit Group: Light
        /// Http Post /restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/flip
        /// </summary>
        public async Task<string> Post(RingCentral.CallPartyFlip callPartyFlip,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Post<string>(this.Path(), callPartyFlip, null, cancellationToken);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Parties
{
    public partial class Index
    {
        public Restapi.Account.Telephony.Sessions.Parties.Flip.Index Flip()
        {
            return new Restapi.Account.Telephony.Sessions.Parties.Flip.Index(this);
        }
    }
}