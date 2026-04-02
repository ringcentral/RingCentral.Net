using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Rcvideo.V2.Account
{
    public partial class Index
    {
        public RestClient rc;
public Rcvideo.V2.Index parent;
public string accountId;
public Index(Rcvideo.V2.Index parent, string accountId = null)
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

namespace RingCentral.Paths.Rcvideo.V2
{
    public partial class Index
    {
        public Rcvideo.V2.Account.Index Account(string accountId = null)
        {
            return new Rcvideo.V2.Account.Index(this, accountId);
        }
    }
}