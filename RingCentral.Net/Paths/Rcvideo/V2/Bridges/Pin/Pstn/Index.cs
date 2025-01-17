using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Rcvideo.V2.Bridges.Pin.Pstn
{
    public class Index
    {
        public Pin.Index parent;
        public string pin;
        public RestClient rc;

        public Index(Pin.Index parent, string pin = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.pin = pin;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && pin != null) return $"{parent.Path()}/pstn/{pin}";

            return $"{parent.Path()}/pstn";
        }

        /// <summary>
        ///     Finds a bridge by Host or Participant PSTN PIN.
        ///     HTTP Method: get
        ///     Endpoint: /rcvideo/v2/bridges/pin/pstn/{pin}
        ///     Rate Limit Group: Medium
        ///     App Permission: Video
        /// </summary>
        public async Task<BridgeResponse> Get(GetBridgeByPstnPinParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            if (pin == null) throw new ArgumentException("Parameter cannot be null", nameof(pin));

            return await rc.Get<BridgeResponse>(Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Rcvideo.V2.Bridges.Pin
{
    public partial class Index
    {
        public Pstn.Index Pstn(string pin = null)
        {
            return new Pstn.Index(this, pin);
        }
    }
}