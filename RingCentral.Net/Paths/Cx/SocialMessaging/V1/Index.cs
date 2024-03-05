namespace RingCentral.Paths.Cx.SocialMessaging.V1
{
    public partial class Index
    {
        public SocialMessaging.Index parent;
        public RestClient rc;

        public Index(SocialMessaging.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/v1";
        }
    }
}

namespace RingCentral.Paths.Cx.SocialMessaging
{
    public partial class Index
    {
        public V1.Index V1()
        {
            return new V1.Index(this);
        }
    }
}