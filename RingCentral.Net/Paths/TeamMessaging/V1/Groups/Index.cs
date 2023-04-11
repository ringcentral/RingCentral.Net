namespace RingCentral.Paths.TeamMessaging.V1.Groups
{
    public partial class Index
    {
        public string groupId;
        public V1.Index parent;
        public RestClient rc;

        public Index(V1.Index parent, string groupId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.groupId = groupId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && groupId != null) return $"{parent.Path()}/groups/{groupId}";
            return $"{parent.Path()}/groups";
        }
    }
}

namespace RingCentral.Paths.TeamMessaging.V1
{
    public partial class Index
    {
        public Groups.Index Groups(string groupId = null)
        {
            return new Groups.Index(this, groupId);
        }
    }
}