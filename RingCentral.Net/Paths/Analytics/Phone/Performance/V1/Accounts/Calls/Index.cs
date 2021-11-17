namespace RingCentral.Paths.Analytics.Phone.Performance.V1.Accounts.Calls
{
    public partial class Index
    {
        public Accounts.Index parent;
        public RestClient rc;

        public Index(Accounts.Index parent)
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

namespace RingCentral.Paths.Analytics.Phone.Performance.V1.Accounts
{
    public partial class Index
    {
        public Calls.Index Calls()
        {
            return new Calls.Index(this);
        }
    }
}