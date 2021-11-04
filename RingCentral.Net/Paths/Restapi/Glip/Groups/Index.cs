namespace RingCentral.Paths.Restapi.Glip.Groups
{
    public partial class Index
    {
        public string groupId;
        public Glip.Index parent;
        public RestClient rc;

        public Index(Glip.Index parent, string groupId = null)
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

namespace RingCentral.Paths.Restapi.Glip
{
    public partial class Index
    {
        public Groups.Index Groups(string groupId = null)
        {
            return new Groups.Index(this, groupId);
        }
    }
}