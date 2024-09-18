using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.V2.Accounts.CostCenters
{
    public class Index
    {
        public Accounts.Index parent;
        public RestClient rc;

        public Index(Accounts.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/cost-centers";
        }

        /// <summary>
        ///     Returns the list of cost centers of the account specified in path.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/v2/accounts/{accountId}/cost-centers
        ///     Rate Limit Group: Light
        ///     App Permission: ReadAccounts
        ///     User Permission: CostCenterManagement
        /// </summary>
        public async Task<CostCenterList> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<CostCenterList>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.V2.Accounts
{
    public partial class Index
    {
        public CostCenters.Index CostCenters()
        {
            return new CostCenters.Index(this);
        }
    }
}