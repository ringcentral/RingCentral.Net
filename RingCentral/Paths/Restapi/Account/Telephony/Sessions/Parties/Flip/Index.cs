using System.Threading.Tasks;

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

        public async Task<string> Post(RingCentral.CallPartyFlip callPartyFlip)
        {
            return await rc.Post<string>(this.Path(), callPartyFlip);
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