using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Rcvideo.V1.Accounts
{
    public partial class Index
    {
        public RestClient rc;
public Rcvideo.V1.Index parent;
public string accountId;
public Index(Rcvideo.V1.Index parent, string accountId = null)
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

namespace RingCentral.Paths.Rcvideo.V1
{
    public partial class Index
    {
        public Rcvideo.V1.Accounts.Index Accounts(string accountId = null)
        {
            return new Rcvideo.V1.Accounts.Index(this, accountId);
        }
    }
}