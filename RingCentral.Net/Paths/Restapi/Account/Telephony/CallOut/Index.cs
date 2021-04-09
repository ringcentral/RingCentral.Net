using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Telephony.CallOut
{
    public class Index
    {
        public Telephony.Index parent;
        public RestClient rc;

        public Index(Telephony.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/call-out";
        }

        /// <summary>
        ///     Creates a new outbound call out session. Currently this method is supported for Softphone/Hardphone only, since
        ///     device IDs for WebRTC/Mobile apps cannot be obtained.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/telephony/call-out
        ///     Rate Limit Group: Heavy
        ///     App Permission: CallControl
        /// </summary>
        public async Task<CallSession> Post(MakeCallOutRequest makeCallOutRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<CallSession>(Path(), makeCallOutRequest, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Telephony
{
    public partial class Index
    {
        public CallOut.Index CallOut()
        {
            return new CallOut.Index(this);
        }
    }
}