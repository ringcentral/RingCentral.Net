using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public RestClient rc;
        public string accountId;
        public Restapi.Index parent;

        public Index(Restapi.Index parent, string accountId = "~")
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

        // Operation: loadAccount
        // Http Get /restapi/v1.0/account/{accountId}
        public async Task<RingCentral.GetAccountInfoResponse> Get()
        {
            if (this.accountId == null)
            {
                throw new System.ArgumentNullException("accountId");
            }

            return await rc.Get<RingCentral.GetAccountInfoResponse>(this.Path());
        }
    }
}

namespace RingCentral.Paths.Restapi
{
    public partial class Index
    {
        public Restapi.Account.Index Account(string accountId = "~")
        {
            return new Restapi.Account.Index(this, accountId);
        }
    }
}