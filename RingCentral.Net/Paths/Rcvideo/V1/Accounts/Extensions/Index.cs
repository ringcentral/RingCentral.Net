using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Rcvideo.V1.Accounts.Extensions
{
    public partial class Index
    {
        public RestClient rc;
public Rcvideo.V1.Accounts.Index parent;
public string extensionId;
public Index(Rcvideo.V1.Accounts.Index parent, string extensionId = null)
      {
this.parent = parent;
this.rc = parent.rc;
this.extensionId = extensionId;
}
        public string Path(bool withParameter = true)
        {
            if (withParameter && extensionId != null)
            {
                return $"{parent.Path()}/extensions/{extensionId}";
            }
            return $"{parent.Path()}/extensions";
        }

    }
}

namespace RingCentral.Paths.Rcvideo.V1.Accounts
{
    public partial class Index
    {
        public Rcvideo.V1.Accounts.Extensions.Index Extensions(string extensionId = null)
        {
            return new Rcvideo.V1.Accounts.Extensions.Index(this, extensionId);
        }
    }
}