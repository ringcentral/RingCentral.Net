using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

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

        /// <summary>
        /// Performs call flip procedure by holding opposite party and calling to the specified target
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/flip
        /// Rate Limit Group: Light
        /// App Permission: CallControl
        /// </summary>
        public async Task<string> Post(RingCentral.CallPartyFlip callPartyFlip,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<string>(this.Path(), callPartyFlip, null, restRequestConfig);
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