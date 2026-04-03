using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Rcvideo.V2.Account.Extension.Bridges.Default
{
    public partial class Index
    {
        public RestClient rc;
        public Rcvideo.V2.Account.Extension.Bridges.Index parent;
        public Index(Rcvideo.V2.Account.Extension.Bridges.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/default";
        }
        /// <summary>
        /// Returns a default bridge (PMI) for the user specified by `accountId`
        /// and `extensionId` identifiers.
        /// 
        /// HTTP Method: get
        /// Endpoint: /rcvideo/v2/account/{accountId}/extension/{extensionId}/bridges/default
        /// Rate Limit Group: Medium
        /// App Permission: Video
        /// </summary>
        public async Task<RingCentral.BridgeResponse> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.BridgeResponse>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Rcvideo.V2.Account.Extension.Bridges
{
    public partial class Index
    {
        public Rcvideo.V2.Account.Extension.Bridges.Default.Index Default()
        {
            return new Rcvideo.V2.Account.Extension.Bridges.Default.Index(this);
        }
    }
}