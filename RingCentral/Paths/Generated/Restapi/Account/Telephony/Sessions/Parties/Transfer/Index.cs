using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Parties.Transfer
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
            return $"{parent.Path()}/transfer";
        }

        public async Task<RingCentral.CallParty> Post(RingCentral.TransferTarget transferTarget)
        {
            return await rc.Post<RingCentral.CallParty>(this.Path(), transferTarget);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Parties
{
    public partial class Index
    {
        public Restapi.Account.Telephony.Sessions.Parties.Transfer.Index Transfer()
        {
            return new Restapi.Account.Telephony.Sessions.Parties.Transfer.Index(this);
        }
    }
}