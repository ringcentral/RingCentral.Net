namespace RingCentral.Paths.Cx.SocialMessaging
{
    public partial class Index
    {
        public Cx.Index parent;
        public RestClient rc;

        public Index(Cx.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/social-messaging";
        }
    }
}

namespace RingCentral.Paths.Cx
{
    public partial class Index
    {
        public SocialMessaging.Index SocialMessaging()
        {
            return new SocialMessaging.Index(this);
        }
    }
}