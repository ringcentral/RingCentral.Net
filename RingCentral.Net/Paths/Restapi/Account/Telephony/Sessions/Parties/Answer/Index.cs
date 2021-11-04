using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Parties.Answer
{
    public class Index
    {
        public Parties.Index parent;
        public RestClient rc;

        public Index(Parties.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/answer";
        }

        /// <summary>
        ///     Answers a call on a certain device by passing the corresponding device ID in request body. Supported for call
        ///     forwarding, call transfer, call flip and call queues.
        ///     HTTP Method: post
        ///     Endpoint:
        ///     /restapi/{apiVersion}/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/answer
        ///     Rate Limit Group: Light
        ///     App Permission: CallControl
        /// </summary>
        public async Task<CallParty> Post(AnswerTarget answerTarget,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<CallParty>(Path(), answerTarget, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Parties
{
    public partial class Index
    {
        public Answer.Index Answer()
        {
            return new Answer.Index(this);
        }
    }
}