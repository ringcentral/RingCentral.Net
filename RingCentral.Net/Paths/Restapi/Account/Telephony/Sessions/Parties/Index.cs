using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Parties
{
    public partial class Index
    {
        public RestClient rc;
        public string partyId;
        public Restapi.Account.Telephony.Sessions.Index parent;

        public Index(Restapi.Account.Telephony.Sessions.Index parent, string partyId = null)
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

        /// <summary>
        /// Operation: Get Call Party Status
        /// Http Get /restapi/v1.0/account/{accountId}/telephony/sessions/{sessionId}/parties/{partyId}
        /// </summary>
        public async Task<RingCentral.CallParty> Get()
        {
            if (this.partyId == null)
            {
                throw new System.ArgumentNullException("partyId");
            }

            return await rc.Get<RingCentral.CallParty>(this.Path());
        }

        /// <summary>
        /// Operation: Update Call Party
        /// Http Patch /restapi/v1.0/account/{accountId}/telephony/sessions/{sessionId}/parties/{partyId}
        /// </summary>
        public async Task<RingCentral.CallParty> Patch(RingCentral.PartyUpdateRequest partyUpdateRequest)
        {
            if (this.partyId == null)
            {
                throw new System.ArgumentNullException("partyId");
            }

            return await rc.Patch<RingCentral.CallParty>(this.Path(), partyUpdateRequest);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions
{
    public partial class Index
    {
        public Restapi.Account.Telephony.Sessions.Parties.Index Parties(string partyId = null)
        {
            return new Restapi.Account.Telephony.Sessions.Parties.Index(this, partyId);
        }
    }
}