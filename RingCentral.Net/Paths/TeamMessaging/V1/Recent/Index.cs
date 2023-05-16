namespace RingCentral.Paths.TeamMessaging.V1.Recent
{
    public partial class Index
    {
        public V1.Index parent;
        public RestClient rc;

        public Index(V1.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/recent";
        }
    }
}

namespace RingCentral.Paths.TeamMessaging.V1
{
    public partial class Index
    {
        public Recent.Index Recent()
        {
            return new Recent.Index(this);
        }
    }
}