using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Ai.Audio.V1
{
    public partial class Index
    {
        public RestClient rc;
public Ai.Audio.Index parent;
public Index(Ai.Audio.Index parent)
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

namespace RingCentral.Paths.Ai.Audio
{
    public partial class Index
    {
        public Ai.Audio.V1.Index V1()
        {
            return new Ai.Audio.V1.Index(this);
        }
    }
}