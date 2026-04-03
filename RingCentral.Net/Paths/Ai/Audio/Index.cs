using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Ai.Audio
{
    public partial class Index
    {
        public RestClient rc;
        public Ai.Index parent;
        public Index(Ai.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path(false)}/audio";
        }

    }
}

namespace RingCentral.Paths.Ai
{
    public partial class Index
    {
        public Ai.Audio.Index Audio()
        {
            return new Ai.Audio.Index(this);
        }
    }
}