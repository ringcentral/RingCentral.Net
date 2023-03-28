using System.Threading.Tasks;

namespace RingCentral.Paths.Rcvideo.V2.Account.Extension.Bridges
{
    public partial class Index
    {
        public Extension.Index parent;
        public RestClient rc;

        public Index(Extension.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/bridges";
        }

        /// <summary>
        ///     Creates a new bridge for the user specified by **accountId** and **extensionId** identifiers. The request body
        ///     should contain JSON object which describes properties of the new bridge.
        ///     The bridge can be created by a user himself, his delegate or any user who has the **Super Admin** privilege.
        ///     HTTP Method: post
        ///     Endpoint: /rcvideo/v2/account/{accountId}/extension/{extensionId}/bridges
        ///     Rate Limit Group: Heavy
        ///     App Permission: Video
        /// </summary>
        public async Task<BridgeResponse> Post(CreateBridgeRequest createBridgeRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<BridgeResponse>(Path(), createBridgeRequest, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Rcvideo.V2.Account.Extension
{
    public partial class Index
    {
        public Bridges.Index Bridges()
        {
            return new Bridges.Index(this);
        }
    }
}