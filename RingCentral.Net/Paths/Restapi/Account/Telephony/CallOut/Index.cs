using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.Telephony.CallOut
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Telephony.Index parent;

        public Index(Restapi.Account.Telephony.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/call-out";
        }

        /// <summary>
        /// Creates a new outbound call out session. Currently this method is supported for Softphone/Hardphone only, since device IDs for WebRTC/Mobile apps cannot be obtained.
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/telephony/call-out
        /// Rate Limit Group: Heavy
        /// App Permission: CallControl
        /// </summary>
        public async Task<RingCentral.CallSession> Post(RingCentral.MakeCallOutRequest makeCallOutRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.CallSession>(this.Path(), makeCallOutRequest, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Telephony
{
    public partial class Index
    {
        public Restapi.Account.Telephony.CallOut.Index CallOut()
        {
            return new Restapi.Account.Telephony.CallOut.Index(this);
        }
    }
}