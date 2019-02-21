using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Glip.Groups
{
    public partial class Index
    {
        public RestClient rc;
        public string groupId;
        public Restapi.Glip.Index parent;

        public Index(Restapi.Glip.Index parent, string groupId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.groupId = groupId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && groupId != null)
            {
                return $"{parent.Path()}/groups/{groupId}";
            }

            return $"{parent.Path()}/groups";
        }

        public async Task<RingCentral.GlipGroupList> List(ListGlipGroupsParameters queryParams = null)
        {
            return await rc.Get<RingCentral.GlipGroupList>(this.Path(false), queryParams);
        }

        public async Task<RingCentral.GlipGroupList> List(object queryParams)
        {
            return await rc.Get<RingCentral.GlipGroupList>(this.Path(false), queryParams);
        }

        public async Task<RingCentral.GlipGroupInfo> Post(RingCentral.GlipCreateGroup glipCreateGroup)
        {
            return await rc.Post<RingCentral.GlipGroupInfo>(this.Path(false), glipCreateGroup);
        }

        public async Task<RingCentral.GlipGroupInfo> Post(object glipCreateGroup)
        {
            return await rc.Post<RingCentral.GlipGroupInfo>(this.Path(false), glipCreateGroup);
        }

        public async Task<RingCentral.GlipGroupInfo> Get()
        {
            if (this.groupId == null)
            {
                throw new System.ArgumentNullException("groupId");
            }

            return await rc.Get<RingCentral.GlipGroupInfo>(this.Path());
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip
{
    public partial class Index
    {
        public Restapi.Glip.Groups.Index Groups(string groupId = null)
        {
            return new Restapi.Glip.Groups.Index(this, groupId);
        }
    }
}