namespace RingCentral.Paths.Restapi.V2.Accounts.Extensions.CommHandling
{
    public partial class Index
    {
        public Extensions.Index parent;
        public RestClient rc;

        public Index(Extensions.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/comm-handling";
        }
    }
}

namespace RingCentral.Paths.Restapi.V2.Accounts.Extensions
{
    public partial class Index
    {
        public CommHandling.Index CommHandling()
        {
            return new CommHandling.Index(this);
        }
    }
}