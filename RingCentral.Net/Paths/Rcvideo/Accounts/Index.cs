namespace RingCentral.Paths.Rcvideo.Accounts
{
    public partial class Index
    {
        public string accountId;
        public Rcvideo.Index parent;
        public RestClient rc;

        public Index(Rcvideo.Index parent, string accountId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.accountId = accountId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && accountId != null) return $"{parent.Path()}/accounts/{accountId}";
            return $"{parent.Path()}/accounts";
        }
    }
}

namespace RingCentral.Paths.Rcvideo
{
    public partial class Index
    {
        public Accounts.Index Accounts(string accountId = null)
        {
            return new Accounts.Index(this, accountId);
        }
    }
}