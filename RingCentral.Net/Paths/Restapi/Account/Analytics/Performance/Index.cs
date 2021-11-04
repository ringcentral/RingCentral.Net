namespace RingCentral.Paths.Restapi.Account.Analytics.Performance
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
            return $"{parent.Path()}/performance";
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Analytics
{
    public partial class Index
    {
        public Performance.Index Performance()
        {
            return new Performance.Index(this);
        }
    }
}