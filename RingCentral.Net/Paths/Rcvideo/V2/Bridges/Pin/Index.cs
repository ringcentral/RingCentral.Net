using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Rcvideo.V2.Bridges.Pin
{
    public partial class Index
    {
        public RestClient rc;
public Rcvideo.V2.Bridges.Index parent;
public Index(Rcvideo.V2.Bridges.Index parent)
      {
this.parent = parent;
this.rc = parent.rc;
}
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path(false)}/pin";
        }

    }
}

namespace RingCentral.Paths.Rcvideo.V2.Bridges
{
    public partial class Index
    {
        public Rcvideo.V2.Bridges.Pin.Index Pin()
        {
            return new Rcvideo.V2.Bridges.Pin.Index(this);
        }
    }
}