using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.PagingOnlyGroups.Devices
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.PagingOnlyGroups.Index parent;

        public Index(Restapi.Account.PagingOnlyGroups.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/devices";
        }

        /// <summary>
        /// Returns the list of paging devices assigned to this group.
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/paging-only-groups/{pagingOnlyGroupId}/devices
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// User Permission: ReadCompanyDevices
        /// </summary>
        public async Task<RingCentral.PagingOnlyGroupDevices> Get(ListPagingGroupDevicesParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.PagingOnlyGroupDevices>(this.Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.PagingOnlyGroups
{
    public partial class Index
    {
        public Restapi.Account.PagingOnlyGroups.Devices.Index Devices()
        {
            return new Restapi.Account.PagingOnlyGroups.Devices.Index(this);
        }
    }
}