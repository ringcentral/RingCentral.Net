using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Rcvideo.V2.Bridges.Pin.Pstn
{
    public partial class Index
    {
        public RestClient rc;
public Rcvideo.V2.Bridges.Pin.Index parent;
public string pin;
public Index(Rcvideo.V2.Bridges.Pin.Index parent, string pin = null)
      {
this.parent = parent;
this.rc = parent.rc;
this.pin = pin;
}
        public string Path(bool withParameter = true)
        {
            if (withParameter && pin != null)
            {
                return $"{parent.Path()}/pstn/{pin}";
            }
            return $"{parent.Path()}/pstn";
        }
        /// <summary>
        /// Finds a bridge by Host or Participant PSTN PIN.
        /// HTTP Method: get
        /// Endpoint: /rcvideo/v2/bridges/pin/pstn/{pin}
        /// Rate Limit Group: Medium
        /// App Permission: Video
        /// </summary>
  public async Task<RingCentral.BridgeResponse> Get(RingCentral.GetBridgeByPstnPinParameters queryParams = null, RestRequestConfig restRequestConfig = null)
  {
if (pin == null)
    {
        throw new System.ArgumentException("Parameter cannot be null", nameof(pin));
    }return await rc.Get<RingCentral.BridgeResponse>(this.Path(), queryParams, restRequestConfig);
  }
    }
}

namespace RingCentral.Paths.Rcvideo.V2.Bridges.Pin
{
    public partial class Index
    {
        public Rcvideo.V2.Bridges.Pin.Pstn.Index Pstn(string pin = null)
        {
            return new Rcvideo.V2.Bridges.Pin.Pstn.Index(this, pin);
        }
    }
}