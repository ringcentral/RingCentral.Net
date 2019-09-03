using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Parties.Play
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
            return $"{parent.Path()}/play";
        }

        /// <summary>
        /// Operation: Play audio files into a party.
        /// Http Post /restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/play
        /// </summary>
        public async Task<string> Post(RingCentral.PlayTarget playTarget)
        {
            return await rc.Post<string>(this.Path(), playTarget);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Parties
{
    public partial class Index
    {
        public Restapi.Account.Telephony.Sessions.Parties.Play.Index Play()
        {
            return new Restapi.Account.Telephony.Sessions.Parties.Play.Index(this);
        }
    }
}