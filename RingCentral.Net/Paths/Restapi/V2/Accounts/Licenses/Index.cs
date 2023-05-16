using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.V2.Accounts.Licenses
{
    public partial class Index
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
            return $"{parent.Path()}/licenses";
        }

        /// <summary>
        ///     Returns the information about account licenses.
        ///     License blocks are grouped by "skuId", "assigned" flag and "costCenterId".
        ///     Only recurring licenses are returned.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/v2/accounts/{accountId}/licenses
        ///     Rate Limit Group: Light
        ///     App Permission: ReadAccounts
        ///     User Permission: LicensesAndInventory
        /// </summary>
        public async Task<LicensesStatisticsResponse> Get(ListLicensesV2Parameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<LicensesStatisticsResponse>(Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.V2.Accounts
{
    public partial class Index
    {
        public Licenses.Index Licenses()
        {
            return new Licenses.Index(this);
        }
    }
}