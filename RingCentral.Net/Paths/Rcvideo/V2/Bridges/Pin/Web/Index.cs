using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Rcvideo.V2.Bridges.Pin.Web
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
            if (withParameter && pin != null) return $"{parent.Path()}/web/{pin}";
            return $"{parent.Path()}/web";
        }

        /// <summary>
        ///     Finds a bridge by short identifier (Web PIN). Also it can be used to find a default bridge by the alias
        ///     (personal meeting name).
        ///     HTTP Method: get
        ///     Endpoint: /rcvideo/v2/bridges/pin/web/{pin}
        ///     Rate Limit Group: Medium
        ///     App Permission: Video
        /// </summary>
        public async Task<BridgeResponse> Get(GetBridgeByWebPinParameters queryParams = null,
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
        public Web.Index Web(string pin = null)
        {
            return new Web.Index(this, pin);
        }
    }
}