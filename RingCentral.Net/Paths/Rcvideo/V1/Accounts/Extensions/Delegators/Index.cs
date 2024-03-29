using System.Threading.Tasks;

namespace RingCentral.Paths.Rcvideo.V1.Accounts.Extensions.Delegators
{
    public class Index
    {
        public Extensions.Index parent;
        public RestClient rc;

        public Index(Extensions.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/delegators";
        }

        /// <summary>
        ///     Returns the list of users who can delegate bridge/meeting creation to the given user.
        ///     HTTP Method: get
        ///     Endpoint: /rcvideo/v1/accounts/{accountId}/extensions/{extensionId}/delegators
        ///     Rate Limit Group: Medium
        ///     App Permission: Video
        /// </summary>
        public async Task<DelegatorsListResult> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<DelegatorsListResult>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Rcvideo.V1.Accounts.Extensions
{
    public partial class Index
    {
        public Delegators.Index Delegators()
        {
            return new Delegators.Index(this);
        }
    }
}