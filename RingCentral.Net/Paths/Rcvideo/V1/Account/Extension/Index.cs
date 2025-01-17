namespace RingCentral.Paths.Rcvideo.V1.Account.Extension
{
    public partial class Index
    {
        public string extensionId;
        public Account.Index parent;
        public RestClient rc;

        public Index(Account.Index parent, string extensionId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.extensionId = extensionId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && extensionId != null) return $"{parent.Path()}/extension/{extensionId}";

            return $"{parent.Path()}/extension";
        }
    }
}

namespace RingCentral.Paths.Rcvideo.V1.Account
{
    public partial class Index
    {
        public Extension.Index Extension(string extensionId = null)
        {
            return new Extension.Index(this, extensionId);
        }
    }
}