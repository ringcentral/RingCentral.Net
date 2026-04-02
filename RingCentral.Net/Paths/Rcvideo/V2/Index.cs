using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Rcvideo.V2
{
    public partial class Index
    {
        public RestClient rc;
public Rcvideo.Index parent;
public Index(Rcvideo.Index parent)
      {
this.parent = parent;
this.rc = parent.rc;
}
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path(false)}/v2";
        }

    }
}

namespace RingCentral.Paths.Rcvideo
{
    public partial class Index
    {
        public Rcvideo.V2.Index V2()
        {
            return new Rcvideo.V2.Index(this);
        }
    }
}