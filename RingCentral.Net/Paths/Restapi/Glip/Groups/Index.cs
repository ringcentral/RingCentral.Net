using System.Threading.Tasks;
using System.Threading;

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

        /// <summary>
        /// Operation: Get User Groups
        /// Http Get /restapi/v1.0/glip/groups
        /// </summary>
        public async Task<RingCentral.GlipGroupList> List(ListGlipGroupsParameters queryParams = null,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Get<RingCentral.GlipGroupList>(this.Path(false), queryParams, cancellationToken);
        }

        /// <summary>
        /// Operation: Create Group
        /// Http Post /restapi/v1.0/glip/groups
        /// </summary>
        public async Task<RingCentral.GlipGroupInfo> Post(RingCentral.GlipCreateGroup glipCreateGroup,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Post<RingCentral.GlipGroupInfo>(this.Path(false), glipCreateGroup, null, cancellationToken);
        }

        /// <summary>
        /// Operation: Get Group
        /// Http Get /restapi/v1.0/glip/groups/{groupId}
        /// </summary>
        public async Task<RingCentral.GlipGroupInfo> Get(CancellationToken? cancellationToken = null)
        {
            if (this.groupId == null)
            {
                throw new System.ArgumentNullException("groupId");
            }

            return await rc.Get<RingCentral.GlipGroupInfo>(this.Path(), null, cancellationToken);
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