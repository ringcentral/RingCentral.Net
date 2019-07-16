using System.Threading.Tasks;

namespace RingCentral.Paths.V1_0.Account.Telephony.Sessions.Parties.Flip
{
    public partial class Index
    {
        public RestClient rc;
        public V1_0.Account.Telephony.Sessions.Parties.Index parent;

        public Index(V1_0.Account.Telephony.Sessions.Parties.Index parent)
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
        /// Http Post /v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/flip
        /// </summary>
        public async Task<string> Post(RingCentral.CallPartyFlip callPartyFlip)
        {
            return await rc.Post<string>(this.Path(), callPartyFlip);
        }
    }
}

namespace RingCentral.Paths.V1_0.Account.Telephony.Sessions.Parties
{
    public partial class Index
    {
        public V1_0.Account.Telephony.Sessions.Parties.Flip.Index Flip()
        {
            return new V1_0.Account.Telephony.Sessions.Parties.Flip.Index(this);
        }
    }
}