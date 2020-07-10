using System.Threading.Tasks;
using System.Threading;

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
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}
        /// Rate Limit Group: Light
        /// App Permission: CallControl
        /// User Permission: undefined
        /// </summary>
        public async Task<RingCentral.CallParty> Get(CancellationToken? cancellationToken = null)
        {
            if (this.partyId == null)
            {
                throw new System.ArgumentNullException("partyId");
            }

            return await rc.Get<RingCentral.CallParty>(this.Path(), null, cancellationToken);
        }

        /// <summary>
        /// Operation: Delete Call Party
        /// HTTP Method: DELETE
        /// Endpoint: /restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}
        /// Rate Limit Group: Light
        /// App Permission: TelephonySessions
        /// User Permission: undefined
        /// </summary>
        public async Task<string> Delete(CancellationToken? cancellationToken = null)
        {
            if (this.partyId == null)
            {
                throw new System.ArgumentNullException("partyId");
            }

            return await rc.Delete<string>(this.Path(), null, cancellationToken);
        }

        /// <summary>
        /// Operation: Update Call Party
        /// HTTP Method: PATCH
        /// Endpoint: /restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}
        /// Rate Limit Group: Light
        /// App Permission: CallControl
        /// User Permission: undefined
        /// </summary>
        public async Task<RingCentral.CallParty> Patch(RingCentral.PartyUpdateRequest partyUpdateRequest,
            CancellationToken? cancellationToken = null)
        {
            if (this.partyId == null)
            {
                throw new System.ArgumentNullException("partyId");
            }

            return await rc.Patch<RingCentral.CallParty>(this.Path(), partyUpdateRequest, null, cancellationToken);
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