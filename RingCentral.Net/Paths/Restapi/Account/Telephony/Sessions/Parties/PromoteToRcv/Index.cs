using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Parties.PromoteToRcv
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
            return $"{parent.Path()}/promote-to-rcv";
        }

        /// <summary>
        ///     Creates a new RCV meeting and move parties to it
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/promote-to-rcv
        ///     Rate Limit Group: Light
        ///     App Permission: CallControl
        /// </summary>
        public async Task<string> Post(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<string>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Parties
{
    public partial class Index
    {
        public PromoteToRcv.Index PromoteToRcv()
        {
            return new PromoteToRcv.Index(this);
        }
    }
}