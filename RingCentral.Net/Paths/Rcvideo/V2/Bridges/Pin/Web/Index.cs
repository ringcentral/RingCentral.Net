using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Rcvideo.V2.Bridges.Pin.Web
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
                return $"{parent.Path()}/web/{pin}";
            }
            return $"{parent.Path()}/web";
        }
        /// <summary>
        /// Finds a bridge by short identifier (Web PIN). Also it can be used to find a default bridge by the alias
/// (personal meeting name).
/// 
        /// HTTP Method: get
        /// Endpoint: /rcvideo/v2/bridges/pin/web/{pin}
        /// Rate Limit Group: Medium
        /// App Permission: Video
        /// </summary>
  public async Task<RingCentral.BridgeResponse> Get(RingCentral.GetBridgeByWebPinParameters queryParams = null, RestRequestConfig restRequestConfig = null)
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
        public Rcvideo.V2.Bridges.Pin.Web.Index Web(string pin = null)
        {
            return new Rcvideo.V2.Bridges.Pin.Web.Index(this, pin);
        }
    }
}