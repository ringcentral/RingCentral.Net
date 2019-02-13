using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Glip.Groups.BulkAssign
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Glip.Groups.Index parent;

        public Index(Restapi.Glip.Groups.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/bulk-assign";
        }

        public async Task<RingCentral.GlipGroupInfo> Post(RingCentral.EditGroupRequest editGroupRequest)
        {
            return await rc.Post<RingCentral.GlipGroupInfo>(this.Path(), editGroupRequest);
        }

        public async Task<RingCentral.GlipGroupInfo> Post(object editGroupRequest)
        {
            return await rc.Post<RingCentral.GlipGroupInfo>(this.Path(), editGroupRequest);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip.Groups
{
    public partial class Index
    {
        public Restapi.Glip.Groups.BulkAssign.Index BulkAssign()
        {
            return new Restapi.Glip.Groups.BulkAssign.Index(this);
        }
    }
}