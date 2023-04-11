namespace RingCentral.Paths.Analytics.Calls.V1.Accounts.Aggregation
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
            return $"{parent.Path()}/aggregation";
        }
    }
}

namespace RingCentral.Paths.Analytics.Calls.V1.Accounts
{
    public partial class Index
    {
        public Aggregation.Index Aggregation()
        {
            return new Aggregation.Index(this);
        }
    }
}