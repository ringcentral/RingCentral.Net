using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Parties.Answer
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
            return $"{parent.Path()}/answer";
        }

        /// <summary>
        /// Answers a call on a certain device by passing the corresponding device ID in request body. Supported for call forwarding, call transfer, call flip and call queues.
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/answer
        /// Rate Limit Group: Light
        /// App Permission: CallControl
        /// </summary>
        public async Task<RingCentral.CallParty> Post(RingCentral.AnswerTarget answerTarget,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.CallParty>(this.Path(), answerTarget, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Parties
{
    public partial class Index
    {
        public Restapi.Account.Telephony.Sessions.Parties.Answer.Index Answer()
        {
            return new Restapi.Account.Telephony.Sessions.Parties.Answer.Index(this);
        }
    }
}