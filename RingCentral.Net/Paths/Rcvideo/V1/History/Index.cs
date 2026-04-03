using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Rcvideo.V1.History
{
    public partial class Index
    {
        public RestClient rc;
        public Rcvideo.V1.Index parent;
        public Index(Rcvideo.V1.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path(false)}/history";
        }

    }
}

namespace RingCentral.Paths.Rcvideo.V1
{
    public partial class Index
    {
        public Rcvideo.V1.History.Index History()
        {
            return new Rcvideo.V1.History.Index(this);
        }
    }
}