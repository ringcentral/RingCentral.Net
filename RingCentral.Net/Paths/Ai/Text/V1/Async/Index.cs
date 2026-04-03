using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Ai.Text.V1.Async
{
    public partial class Index
    {
        public RestClient rc;
        public Ai.Text.V1.Index parent;
        public Index(Ai.Text.V1.Index parent)
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

namespace RingCentral.Paths.Ai.Text.V1
{
    public partial class Index
    {
        public Ai.Text.V1.Async.Index Async()
        {
            return new Ai.Text.V1.Async.Index(this);
        }
    }
}