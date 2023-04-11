namespace RingCentral.Paths.Webinar.Notifications
{
    public partial class Index
    {
        public Webinar.Index parent;
        public RestClient rc;

        public Index(Webinar.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/notifications";
        }
    }
}

namespace RingCentral.Paths.Webinar
{
    public partial class Index
    {
        public Notifications.Index Notifications()
        {
            return new Notifications.Index(this);
        }
    }
}