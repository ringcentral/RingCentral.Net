using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Ai.Status.V1
{
    public partial class Index
    {
        public RestClient rc;
public Ai.Status.Index parent;
public Index(Ai.Status.Index parent)
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

namespace RingCentral.Paths.Ai.Status
{
    public partial class Index
    {
        public Ai.Status.V1.Index V1()
        {
            return new Ai.Status.V1.Index(this);
        }
    }
}