using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Rcvideo.V1.History.Account
{
    public partial class Index
    {
        public RestClient rc;
public Rcvideo.V1.History.Index parent;
public string accountId;
public Index(Rcvideo.V1.History.Index parent, string accountId = null)
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

namespace RingCentral.Paths.Rcvideo.V1.History
{
    public partial class Index
    {
        public Rcvideo.V1.History.Account.Index Account(string accountId = null)
        {
            return new Rcvideo.V1.History.Account.Index(this, accountId);
        }
    }
}