using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Parties.Supervise
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
            return $"{parent.Path()}/supervise";
        }

        /// <summary>
        /// Operation: Supervise Call Party
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/supervise
        /// Rate Limit Group: Light
        /// App Permission: CallControl
        /// User Permission: undefined
        /// </summary>
        public async Task<RingCentral.PartySuperviseResponse> Post(
            RingCentral.PartySuperviseRequest partySuperviseRequest, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.PartySuperviseResponse>(this.Path(), partySuperviseRequest, null,
                restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Parties
{
    public partial class Index
    {
        public Restapi.Account.Telephony.Sessions.Parties.Supervise.Index Supervise()
        {
            return new Restapi.Account.Telephony.Sessions.Parties.Supervise.Index(this);
        }
    }
}