using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Parties
{
    public partial class Index
    {
        public Sessions.Index parent;
        public string partyId;
        public RestClient rc;

        public Index(Sessions.Index parent, string partyId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.partyId = partyId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && partyId != null) return $"{parent.Path()}/parties/{partyId}";

            return $"{parent.Path()}/parties";
        }

        /// <summary>
        ///     Returns a call party status by ID.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}
        ///     Rate Limit Group: Light
        ///     App Permission: CallControl
        /// </summary>
        public async Task<CallParty> Get(RestRequestConfig restRequestConfig = null)
        {
            if (partyId == null) throw new ArgumentException("Parameter cannot be null", nameof(partyId));

            return await rc.Get<CallParty>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Deletes a party from a call session by ID. A party can be deleted only if supervised or parked. It is possible to
        ///     delete only one conference participant per request.
        ///     HTTP Method: delete
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}
        ///     Rate Limit Group: Light
        ///     App Permission: CallControl
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            if (partyId == null) throw new ArgumentException("Parameter cannot be null", nameof(partyId));

            return await rc.Delete<string>(Path(), null, null, restRequestConfig);
        }

        /// <summary>
        ///     Modifies a call party by ID. There is a known limitation for Mute scenario - mute via REST API doesn't work with
        ///     mute placed via RingCentral apps or HardPhone. It means that if you muted participant via Call Control API and
        ///     RingCentral Desktop app you need to unmute both endpoints to bring the media back.
        ///     HTTP Method: patch
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}
        ///     Rate Limit Group: Light
        ///     App Permission: CallControl
        /// </summary>
        public async Task<CallParty> Patch(PartyUpdateRequest partyUpdateRequest,
            RestRequestConfig restRequestConfig = null)
        {
            if (partyId == null) throw new ArgumentException("Parameter cannot be null", nameof(partyId));

            return await rc.Patch<CallParty>(Path(), partyUpdateRequest, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions
{
    public partial class Index
    {
        public Parties.Index Parties(string partyId = null)
        {
            return new Parties.Index(this, partyId);
        }
    }
}