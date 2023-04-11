namespace RingCentral.Paths.Webinar.Notifications.V1
{
    public partial class Index
    {
        public Notifications.Index parent;
        public RestClient rc;

        public Index(Notifications.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/v1";
        }
    }
}

namespace RingCentral.Paths.Webinar.Notifications
{
    public partial class Index
    {
        public V1.Index V1()
        {
            return new V1.Index(this);
        }
    }
}