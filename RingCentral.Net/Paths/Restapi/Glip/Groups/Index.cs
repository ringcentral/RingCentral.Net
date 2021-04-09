namespace RingCentral.Paths.Restapi.Glip.Groups
{
    public partial class Index
    {
        public Glip.Index parent;
        public RestClient rc;

        public Index(Glip.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/groups";
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip
{
    public partial class Index
    {
        public Groups.Index Groups()
        {
            return new Groups.Index(this);
        }
    }
}