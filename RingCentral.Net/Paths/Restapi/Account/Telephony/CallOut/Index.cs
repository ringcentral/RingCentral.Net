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
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/call-out";
        }
        /// <summary>
        /// Creates a new CallOut telephony session: an outbound call from the caller described in `from`
        /// to the destination in `to`. The caller may be identified with `from.deviceId` or with
        /// `from.extensionId` (internal extension / mailbox id); use one or the other, not both.
        /// When using `from.deviceId`, only Softphone and Hardphone device instance ids are supported;
        /// WebRTC/Mobile clients do not expose usable device ids for this API today.
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/telephony/call-out
        /// Rate Limit Group: Heavy
        /// App Permission: CallControl
        /// </summary>
        public async Task<RingCentral.CallSession> Post(RingCentral.MakeCallOutRequest makeCallOutRequest, RestRequestConfig restRequestConfig = null)
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