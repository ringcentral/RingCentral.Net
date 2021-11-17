namespace RingCentral.Paths.Analytics.Phone.Performance
{
    public partial class Index
    {
        public Phone.Index parent;
        public RestClient rc;

        public Index(Phone.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/performance";
        }
    }
}

namespace RingCentral.Paths.Analytics.Phone
{
    public partial class Index
    {
        public Performance.Index Performance()
        {
            return new Performance.Index(this);
        }
    }
}