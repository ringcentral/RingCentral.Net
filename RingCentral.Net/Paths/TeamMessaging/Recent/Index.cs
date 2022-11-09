namespace RingCentral.Paths.TeamMessaging.Recent
{
    public partial class Index
    {
        public TeamMessaging.Index parent;
        public RestClient rc;

        public Index(TeamMessaging.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/recent";
        }
    }
}

namespace RingCentral.Paths.TeamMessaging
{
    public partial class Index
    {
        public Recent.Index Recent()
        {
            return new Recent.Index(this);
        }
    }
}