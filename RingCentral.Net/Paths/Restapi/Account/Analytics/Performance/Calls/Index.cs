namespace RingCentral.Paths.Restapi.Account.Analytics.Performance.Calls
{
    public partial class Index
    {
        public Performance.Index parent;
        public RestClient rc;

        public Index(Performance.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/calls";
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Analytics.Performance
{
    public partial class Index
    {
        public Calls.Index Calls()
        {
            return new Calls.Index(this);
        }
    }
}