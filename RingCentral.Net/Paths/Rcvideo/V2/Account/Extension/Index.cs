using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Rcvideo.V2.Account.Extension
{
    public partial class Index
    {
        public RestClient rc;
public Rcvideo.V2.Account.Index parent;
public string extensionId;
public Index(Rcvideo.V2.Account.Index parent, string extensionId = null)
      {
this.parent = parent;
this.rc = parent.rc;
this.extensionId = extensionId;
}
        public string Path(bool withParameter = true)
        {
            if (withParameter && extensionId != null)
            {
                return $"{parent.Path()}/extension/{extensionId}";
            }
            return $"{parent.Path()}/extension";
        }

    }
}

namespace RingCentral.Paths.Rcvideo.V2.Account
{
    public partial class Index
    {
        public Rcvideo.V2.Account.Extension.Index Extension(string extensionId = null)
        {
            return new Rcvideo.V2.Account.Extension.Index(this, extensionId);
        }
    }
}