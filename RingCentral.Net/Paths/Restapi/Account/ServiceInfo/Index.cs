using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.ServiceInfo
{
    public class Index
    {
        public Account.Index parent;
        public RestClient rc;

        public Index(Account.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/service-info";
        }

        /// <summary>
        ///     Returns the information about service plan, available features
        ///     and limitations for a particular RingCentral customer account.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/service-info
        ///     Rate Limit Group: Light
        ///     App Permission: ReadAccounts
        ///     User Permission: ReadServicePlanInfo
        /// </summary>
        public async Task<AccountServiceInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<AccountServiceInfo>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public ServiceInfo.Index ServiceInfo()
        {
            return new ServiceInfo.Index(this);
        }
    }
}