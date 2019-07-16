namespace RingCentral.Paths.V1_0.Account
{
    public partial class Index
    {
        public RestClient rc;
        public string accountId;
        public V1_0.Index parent;

        public Index(V1_0.Index parent, string accountId = "~")
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.accountId = accountId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && accountId != null)
            {
                return $"{parent.Path()}/account/{accountId}";
            }

            return $"{parent.Path()}/account";
        }
    }
}

namespace RingCentral.Paths.V1_0
{
    public partial class Index
    {
        public V1_0.Account.Index Account(string accountId = "~")
        {
            return new V1_0.Account.Index(this, accountId);
        }
    }
}