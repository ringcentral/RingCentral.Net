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

        public class ListQueryParams
        {
            // Type of groups to be fetched (by default all type of groups will be fetched)
            // Enum: Group, Team, PrivateChat, PersonalChat
            public string type;

            // Number of groups to be fetched by one request. The maximum value is 250, by default - 30
            public string recordCount;

            // Pagination token.
            public string pageToken;
        }

        public async Task<RingCentral.GlipGroupList> List(ListQueryParams queryParams = null)
        {
            return await rc.Get<RingCentral.GlipGroupList>(this.Path(false), queryParams);
        }

        public async Task<RingCentral.GlipGroupInfo> Post(RingCentral.GlipCreateGroup glipCreateGroup)
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