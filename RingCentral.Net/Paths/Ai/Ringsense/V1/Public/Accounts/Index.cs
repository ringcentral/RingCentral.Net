using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Ai.Ringsense.V1.Public.Accounts
{
    public partial class Index
    {
        public RestClient rc;
        public Ai.Ringsense.V1.Public.Index parent;
        public string accountId;
        public Index(Ai.Ringsense.V1.Public.Index parent, string accountId = null)
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

namespace RingCentral.Paths.Ai.Ringsense.V1.Public
{
    public partial class Index
    {
        public Ai.Ringsense.V1.Public.Accounts.Index Accounts(string accountId = null)
        {
            return new Ai.Ringsense.V1.Public.Accounts.Index(this, accountId);
        }
    }
}