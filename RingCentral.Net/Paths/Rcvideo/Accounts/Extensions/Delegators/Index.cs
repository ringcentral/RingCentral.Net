using System.Threading.Tasks;

namespace RingCentral.Paths.Rcvideo.Accounts.Extensions.Delegators
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

        public string Path()
        {
            return $"{parent.Path()}/delegators";
        }

        /// <summary>
        ///     Returns the list of users who can delegate bridge/meeting creation to the given user.
        ///     HTTP Method: get
        ///     Endpoint: /rcvideo/{version}/accounts/{accountId}/extensions/{extensionId}/delegators
        ///     Rate Limit Group: Medium
        ///     App Permission: Video
        /// </summary>
        public async Task<DelegatorsListResult> Get(RcvListDelegatorsParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<DelegatorsListResult>(Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Rcvideo.Accounts.Extensions
{
    public partial class Index
    {
        public Delegators.Index Delegators()
        {
            return new Delegators.Index(this);
        }
    }
}