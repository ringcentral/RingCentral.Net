namespace RingCentral.Paths.Analytics.Calls
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

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/calls";
        }
    }
}

namespace RingCentral.Paths.Analytics
{
    public partial class Index
    {
        public Calls.Index Calls()
        {
            return new Calls.Index(this);
        }
    }
}