using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.PagingOnlyGroups.Devices
{
    public class Index
    {
        public PagingOnlyGroups.Index parent;
        public RestClient rc;

        public Index(PagingOnlyGroups.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/devices";
        }

        /// <summary>
        ///     Returns a list of paging devices assigned to this group.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/paging-only-groups/{pagingOnlyGroupId}/devices
        ///     Rate Limit Group: Light
        ///     App Permission: ReadAccounts
        ///     User Permission: ReadCompanyDevices
        /// </summary>
        public async Task<PagingOnlyGroupDevices> Get(ListPagingGroupDevicesParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<PagingOnlyGroupDevices>(Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.PagingOnlyGroups
{
    public partial class Index
    {
        public Devices.Index Devices()
        {
            return new Devices.Index(this);
        }
    }
}