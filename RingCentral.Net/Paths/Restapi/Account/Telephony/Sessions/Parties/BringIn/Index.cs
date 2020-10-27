using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Parties.BringIn
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
            return $"{parent.Path()}/bring-in";
        }

        /// <summary>
        /// Operation: Bring-In Call Party
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/bring-in
        /// Rate Limit Group: Light
        /// App Permission: TelephonySessions
        /// User Permission: undefined
        /// </summary>
        public async Task<RingCentral.CallParty> Post(RingCentral.AddPartyRequest addPartyRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.CallParty>(this.Path(), addPartyRequest, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Parties
{
    public partial class Index
    {
        public Restapi.Account.Telephony.Sessions.Parties.BringIn.Index BringIn()
        {
            return new Restapi.Account.Telephony.Sessions.Parties.BringIn.Index(this);
        }
    }
}