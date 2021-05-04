using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Parties
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Telephony.Sessions.Index parent;
        public string partyId;

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
        /// Returns a call party status by ID.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}
        /// Rate Limit Group: Light
        /// App Permission: CallControl
        /// </summary>
        public async Task<RingCentral.CallParty> Get(RestRequestConfig restRequestConfig = null)
        {
            if (partyId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(partyId));
            }

            return await rc.Get<RingCentral.CallParty>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Removes a party from a call session by ID. A party can be deleted only if supervised or parked. It is possible to delete only one conference participant per request.
        /// HTTP Method: delete
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}
        /// Rate Limit Group: Light
        /// App Permission: TelephonySessions
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            if (partyId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(partyId));
            }

            return await rc.Delete<string>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Modifies a call party by ID. There is a known limitation for Mute scenario - mute via REST API doesn't work with mute placed via RingCentral apps or HardPhone. It means that if you muted participant via Call Control API and Ringcentral Desktop app you need to unmute both endpoints to bring the media back.
        /// HTTP Method: patch
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}
        /// Rate Limit Group: Light
        /// App Permission: CallControl
        /// </summary>
        public async Task<RingCentral.CallParty> Patch(RingCentral.PartyUpdateRequest partyUpdateRequest,
            RestRequestConfig restRequestConfig = null)
        {
            if (partyId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(partyId));
            }

            return await rc.Patch<RingCentral.CallParty>(this.Path(), partyUpdateRequest, null, restRequestConfig);
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