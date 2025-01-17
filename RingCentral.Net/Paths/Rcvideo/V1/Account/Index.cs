namespace RingCentral.Paths.Rcvideo.V1.Account
{
    public partial class Index
    {
        public string accountId;
        public V1.Index parent;
        public RestClient rc;

        public Index(V1.Index parent, string accountId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.accountId = accountId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && accountId != null) return $"{parent.Path()}/account/{accountId}";

            return $"{parent.Path()}/account";
        }
    }
}

namespace RingCentral.Paths.Rcvideo.V1
{
    public partial class Index
    {
        public Account.Index Account(string accountId = null)
        {
            return new Account.Index(this, accountId);
        }
    }
}