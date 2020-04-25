using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Account.Extension.Features
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Extension.Index parent;

        public Index(Restapi.Account.Extension.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/features";
        }

        /// <summary>
        /// Operation: Get User Features
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/features
        /// Rate Limit Group: Medium
        /// App Permission Required: ReadAccounts
        /// User Permission Required: ReadExtensions
        /// </summary>
        public async Task<RingCentral.FeatureList> Get(ReadUserFeaturesParameters queryParams = null,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Get<RingCentral.FeatureList>(this.Path(), queryParams, cancellationToken);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.Features.Index Features()
        {
            return new Restapi.Account.Extension.Features.Index(this);
        }
    }
}