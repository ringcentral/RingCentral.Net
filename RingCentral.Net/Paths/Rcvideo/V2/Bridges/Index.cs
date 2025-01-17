using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Rcvideo.V2.Bridges
{
    public partial class Index
    {
        public string bridgeId;
        public V2.Index parent;
        public RestClient rc;

        public Index(V2.Index parent, string bridgeId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.bridgeId = bridgeId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && bridgeId != null) return $"{parent.Path()}/bridges/{bridgeId}";

            return $"{parent.Path()}/bridges";
        }

        /// <summary>
        ///     Returns a bridge by **bridgeId** identifier.
        ///     HTTP Method: get
        ///     Endpoint: /rcvideo/v2/bridges/{bridgeId}
        ///     Rate Limit Group: Medium
        ///     App Permission: Video
        /// </summary>
        public async Task<BridgeResponse> Get(GetBridgeParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            if (bridgeId == null) throw new ArgumentException("Parameter cannot be null", nameof(bridgeId));

            return await rc.Get<BridgeResponse>(Path(), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Deletes a bridge by **bridgeId** identifier.
        ///     Deletion can only be done by bridge owner, his delegate or any user who has the **Super Admin** privilege.
        ///     HTTP Method: delete
        ///     Endpoint: /rcvideo/v2/bridges/{bridgeId}
        ///     Rate Limit Group: Medium
        ///     App Permission: Video
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            if (bridgeId == null) throw new ArgumentException("Parameter cannot be null", nameof(bridgeId));

            return await rc.Delete<string>(Path(), null, null, restRequestConfig);
        }

        /// <summary>
        ///     Updates a bridge by **bridgeId** identifier. The request body should contain JSON object with updating properties.
        ///     Update can only be done by bridge owner, his delegate or any user who has the **Super Admin** privilege.
        ///     HTTP Method: patch
        ///     Endpoint: /rcvideo/v2/bridges/{bridgeId}
        ///     Rate Limit Group: Medium
        ///     App Permission: Video
        /// </summary>
        public async Task<BridgeResponse> Patch(UpdateBridgeRequest updateBridgeRequest,
            RestRequestConfig restRequestConfig = null)
        {
            if (bridgeId == null) throw new ArgumentException("Parameter cannot be null", nameof(bridgeId));

            return await rc.Patch<BridgeResponse>(Path(), updateBridgeRequest, null,
                restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Rcvideo.V2
{
    public partial class Index
    {
        public Bridges.Index Bridges(string bridgeId = null)
        {
            return new Bridges.Index(this, bridgeId);
        }
    }
}