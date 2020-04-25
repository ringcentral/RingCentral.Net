using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Account.ServiceInfo
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Index parent;

        public Index(Restapi.Account.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/service-info";
        }

        /// <summary>
        /// Operation: Get Account Service Info
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/service-info
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// User Permission: ReadServicePlanInfo
        /// </summary>
        public async Task<RingCentral.GetServiceInfoResponse> Get(CancellationToken? cancellationToken = null)
        {
            return await rc.Get<RingCentral.GetServiceInfoResponse>(this.Path(), null, cancellationToken);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public Restapi.Account.ServiceInfo.Index ServiceInfo()
        {
            return new Restapi.Account.ServiceInfo.Index(this);
        }
    }
}