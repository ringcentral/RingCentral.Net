namespace RingCentral.Paths.Analytics.Phone
{
    public partial class Index
    {
        public Analytics.Index parent;
        public RestClient rc;

        public Index(Analytics.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/phone";
        }
    }
}

namespace RingCentral.Paths.Analytics
{
    public partial class Index
    {
        public Phone.Index Phone()
        {
            return new Phone.Index(this);
        }
    }
}