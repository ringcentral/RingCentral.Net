using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Ai.Text
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
            return $"{parent.Path(false)}/text";
        }

    }
}

namespace RingCentral.Paths.Ai
{
    public partial class Index
    {
        public Ai.Text.Index Text()
        {
            return new Ai.Text.Index(this);
        }
    }
}