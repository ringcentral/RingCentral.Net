namespace RingCentral.Paths.Rcvideo.V1.History.Account
{
    public partial class Index
    {
        public string accountId;
        public History.Index parent;
        public RestClient rc;

        public Index(History.Index parent, string accountId = null)
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

namespace RingCentral.Paths.Rcvideo.V1.History
{
    public partial class Index
    {
        public Account.Index Account(string accountId = null)
        {
            return new Account.Index(this, accountId);
        }
    }
}