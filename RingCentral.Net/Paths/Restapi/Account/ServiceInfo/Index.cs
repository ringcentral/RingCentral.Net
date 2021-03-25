using System.Threading.Tasks;

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
        /// Returns the information about service plan, available features and limitations for a particular RingCentral customer account.
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/service-info
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// User Permission: ReadServicePlanInfo
        /// </summary>
        public async Task<RingCentral.GetServiceInfoResponse> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.GetServiceInfoResponse>(this.Path(), null, restRequestConfig);
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