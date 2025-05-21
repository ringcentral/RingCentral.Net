using System.Threading.Tasks;

namespace RingCentral.Paths.Rcvideo.V2.Account.Extension.Bridges.Default
{
    public class Index
    {
        public Bridges.Index parent;
        public RestClient rc;

        public Index(Bridges.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/default";
        }

        /// <summary>
        ///     Returns a default bridge (PMI) for the user specified by `accountId`
        ///     and `extensionId` identifiers.
        ///     HTTP Method: get
        ///     Endpoint: /rcvideo/v2/account/{accountId}/extension/{extensionId}/bridges/default
        ///     Rate Limit Group: Medium
        ///     App Permission: Video
        /// </summary>
        public async Task<BridgeResponse> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<BridgeResponse>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Rcvideo.V2.Account.Extension.Bridges
{
    public partial class Index
    {
        public Default.Index Default()
        {
            return new Default.Index(this);
        }
    }
}