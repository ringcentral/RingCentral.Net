namespace RingCentral.Paths.Rcvideo.V1.Accounts.Extensions
{
    public partial class Index
    {
        public string extensionId;
        public Accounts.Index parent;
        public RestClient rc;

        public Index(Accounts.Index parent, string extensionId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.extensionId = extensionId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && extensionId != null) return $"{parent.Path()}/extensions/{extensionId}";
            return $"{parent.Path()}/extensions";
        }
    }
}

namespace RingCentral.Paths.Rcvideo.V1.Accounts
{
    public partial class Index
    {
        public Extensions.Index Extensions(string extensionId = null)
        {
            return new Extensions.Index(this, extensionId);
        }
    }
}