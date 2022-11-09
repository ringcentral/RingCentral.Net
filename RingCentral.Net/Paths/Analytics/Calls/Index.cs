namespace RingCentral.Paths.Analytics.Calls
{
    public partial class Index
    {
        public Analytics.Index parent;
        public RestClient rc;
        public string version;

        public Index(Analytics.Index parent, string version = "v1")
        {
            this.parent = parent;
            rc = parent.rc;
            this.version = version;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && version != null) return $"{parent.Path()}/calls/{version}";
            return $"{parent.Path()}/calls";
        }
    }
}

namespace RingCentral.Paths.Analytics
{
    public partial class Index
    {
        public Calls.Index Calls(string version = "v1")
        {
            return new Calls.Index(this, version);
        }
    }
}