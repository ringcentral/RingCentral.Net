namespace RingCentral.Paths.V1_0.Account.Telephony.Sessions.Parties
{
    public partial class Index
    {
        public RestClient rc;
        public string partyId;
        public V1_0.Account.Telephony.Sessions.Index parent;

        public Index(V1_0.Account.Telephony.Sessions.Index parent, string partyId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.partyId = partyId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && partyId != null)
            {
                return $"{parent.Path()}/parties/{partyId}";
            }

            return $"{parent.Path()}/parties";
        }
    }
}

namespace RingCentral.Paths.V1_0.Account.Telephony.Sessions
{
    public partial class Index
    {
        public V1_0.Account.Telephony.Sessions.Parties.Index Parties(string partyId = null)
        {
            return new V1_0.Account.Telephony.Sessions.Parties.Index(this, partyId);
        }
    }
}