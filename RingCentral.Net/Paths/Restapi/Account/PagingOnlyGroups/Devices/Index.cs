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
        /// Operation: Get Paging Group Devices
        /// Http Get /restapi/v1.0/account/{accountId}/paging-only-groups/{pagingOnlyGroupId}/devices
        /// </summary>
        public async Task<RingCentral.PagingOnlyGroupDevices> Get(ListPagingGroupDevicesParameters queryParams = null)
        {
            return await rc.Get<RingCentral.PagingOnlyGroupDevices>(this.Path(), queryParams);
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