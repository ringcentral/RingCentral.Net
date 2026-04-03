using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Rcvideo.V2.Bridges
{
    public partial class Index
    {
        public RestClient rc;
        public Rcvideo.V2.Index parent;
        public string bridgeId;
        public Index(Rcvideo.V2.Index parent, string bridgeId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.bridgeId = bridgeId;
        }
        public string Path(bool withParameter = true)
        {
            if (withParameter && bridgeId != null)
            {
                return $"{parent.Path()}/bridges/{bridgeId}";
            }
            return $"{parent.Path()}/bridges";
        }
        /// <summary>
        /// Returns a bridge by `bridgeId` identifier.
        /// HTTP Method: get
        /// Endpoint: /rcvideo/v2/bridges/{bridgeId}
        /// Rate Limit Group: Medium
        /// App Permission: Video
        /// </summary>
        public async Task<RingCentral.BridgeResponse> Get(RingCentral.GetBridgeParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            if (bridgeId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(bridgeId));
            }
            return await rc.Get<RingCentral.BridgeResponse>(this.Path(), queryParams, restRequestConfig);
        }

        /// <summary>
        /// Deletes a bridge by `bridgeId` identifier.
        /// Deletion can only be done by the bridge owner, an owner's delegate or any user who has the **Super Admin** privilege.
        /// 
        /// HTTP Method: delete
        /// Endpoint: /rcvideo/v2/bridges/{bridgeId}
        /// Rate Limit Group: Medium
        /// App Permission: Video
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            if (bridgeId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(bridgeId));
            }
            return await rc.Delete<string>(this.Path(), null, null, restRequestConfig);
        }

        /// <summary>
        /// Updates a bridge by `bridgeId` identifier. The request body should contain JSON object with updating properties.
        /// Update can only be done by the bridge owner, an owner's delegate or any user who has the **Super Admin** privilege.
        /// 
        /// HTTP Method: patch
        /// Endpoint: /rcvideo/v2/bridges/{bridgeId}
        /// Rate Limit Group: Medium
        /// App Permission: Video
        /// </summary>
        public async Task<RingCentral.BridgeResponse> Patch(RingCentral.UpdateBridgeRequest updateBridgeRequest, RestRequestConfig restRequestConfig = null)
        {
            if (bridgeId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(bridgeId));
            }
            return await rc.Patch<RingCentral.BridgeResponse>(this.Path(), updateBridgeRequest, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Rcvideo.V2
{
    public partial class Index
    {
        public Rcvideo.V2.Bridges.Index Bridges(string bridgeId = null)
        {
            return new Rcvideo.V2.Bridges.Index(this, bridgeId);
        }
    }
}