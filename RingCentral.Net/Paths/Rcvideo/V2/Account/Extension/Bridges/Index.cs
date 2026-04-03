using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Rcvideo.V2.Account.Extension.Bridges
{
    public partial class Index
    {
        public RestClient rc;
        public Rcvideo.V2.Account.Extension.Index parent;
        public Index(Rcvideo.V2.Account.Extension.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/bridges";
        }
        /// <summary>
        /// Creates a new bridge for the user specified by `accountId` and `extensionId` identifiers. The request body
        /// should contain JSON object which describes properties of the new bridge.
        /// The bridge can be created by the owner, a delegate or any user who has the **Super Admin** privilege.
        /// 
        /// HTTP Method: post
        /// Endpoint: /rcvideo/v2/account/{accountId}/extension/{extensionId}/bridges
        /// Rate Limit Group: Heavy
        /// App Permission: Video
        /// </summary>
        public async Task<RingCentral.BridgeResponse> Post(RingCentral.CreateBridgeRequest createBridgeRequest, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.BridgeResponse>(this.Path(), createBridgeRequest, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Rcvideo.V2.Account.Extension
{
    public partial class Index
    {
        public Rcvideo.V2.Account.Extension.Bridges.Index Bridges()
        {
            return new Rcvideo.V2.Account.Extension.Bridges.Index(this);
        }
    }
}