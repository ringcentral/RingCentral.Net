using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Analytics.Calls.V1.Accounts
{
    public partial class Index
    {
        public RestClient rc;
        public Analytics.Calls.V1.Index parent;
        public string accountId;
        public Index(Analytics.Calls.V1.Index parent, string accountId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.accountId = accountId;
        }
        public string Path(bool withParameter = true)
        {
            if (withParameter && accountId != null)
            {
                return $"{parent.Path()}/accounts/{accountId}";
            }
            return $"{parent.Path()}/accounts";
        }

    }
}

namespace RingCentral.Paths.Analytics.Calls.V1
{
    public partial class Index
    {
        public Analytics.Calls.V1.Accounts.Index Accounts(string accountId = null)
        {
            return new Analytics.Calls.V1.Accounts.Index(this, accountId);
        }
    }
}