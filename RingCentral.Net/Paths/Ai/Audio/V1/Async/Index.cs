using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Ai.Audio.V1.Async
{
    public partial class Index
    {
        public RestClient rc;
public Ai.Audio.V1.Index parent;
public Index(Ai.Audio.V1.Index parent)
      {
this.parent = parent;
this.rc = parent.rc;
}
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path(false)}/async";
        }

    }
}

namespace RingCentral.Paths.Ai.Audio.V1
{
    public partial class Index
    {
        public Ai.Audio.V1.Async.Index Async()
        {
            return new Ai.Audio.V1.Async.Index(this);
        }
    }
}