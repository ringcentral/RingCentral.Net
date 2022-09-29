namespace RingCentral.Paths.Analytics.Calls.V1.Accounts.Timeline
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
            return $"{parent.Path()}/timeline";
        }
    }
}

namespace RingCentral.Paths.Analytics.Calls.V1.Accounts
{
    public partial class Index
    {
        public Timeline.Index Timeline()
        {
            return new Timeline.Index(this);
        }
    }
}