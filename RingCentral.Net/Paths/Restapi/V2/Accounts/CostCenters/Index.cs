using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.V2.Accounts.CostCenters
{
    public partial class Index
    {
        public RestClient rc;
public Restapi.V2.Accounts.Index parent;
public Index(Restapi.V2.Accounts.Index parent)
      {
this.parent = parent;
this.rc = parent.rc;
}
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/cost-centers";
        }
        /// <summary>
        /// Returns the list of cost centers of the account specified in path.
        /// HTTP Method: get
        /// Endpoint: /restapi/v2/accounts/{accountId}/cost-centers
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// User Permission: CostCenterManagement
        /// </summary>
  public async Task<RingCentral.CostCenterList> Get(RestRequestConfig restRequestConfig = null)
  {
return await rc.Get<RingCentral.CostCenterList>(this.Path(), null, restRequestConfig);
  }
    }
}

namespace RingCentral.Paths.Restapi.V2.Accounts
{
    public partial class Index
    {
        public Restapi.V2.Accounts.CostCenters.Index CostCenters()
        {
            return new Restapi.V2.Accounts.CostCenters.Index(this);
        }
    }
}