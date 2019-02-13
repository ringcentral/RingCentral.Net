using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.PagingOnlyGroups.BulkAssign
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
            return $"{parent.Path()}/bulk-assign";
        }

        public async Task<string> Post(RingCentral.EditPagingGroupRequest editPagingGroupRequest)
        {
            return await rc.Post<string>(this.Path(), editPagingGroupRequest);
        }

        public async Task<string> Post(object editPagingGroupRequest)
        {
            return await rc.Post<string>(this.Path(), editPagingGroupRequest);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.PagingOnlyGroups
{
    public partial class Index
    {
        public Restapi.Account.PagingOnlyGroups.BulkAssign.Index BulkAssign()
        {
            return new Restapi.Account.PagingOnlyGroups.BulkAssign.Index(this);
        }
    }
}