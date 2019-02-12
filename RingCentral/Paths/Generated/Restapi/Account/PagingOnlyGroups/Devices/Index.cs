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

        public async Task<RingCentral.PagingOnlyGroupDevices> Get()
        {
            return await rc.Get<RingCentral.PagingOnlyGroupDevices>(this.Path());
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