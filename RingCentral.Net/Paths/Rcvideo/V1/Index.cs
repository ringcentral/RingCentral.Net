using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Rcvideo.V1
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
            return $"{parent.Path(false)}/v1";
        }

    }
}

namespace RingCentral.Paths.Rcvideo
{
    public partial class Index
    {
        public Rcvideo.V1.Index V1()
        {
            return new Rcvideo.V1.Index(this);
        }
    }
}