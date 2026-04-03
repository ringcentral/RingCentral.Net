using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Ai.Insights.V1.Async
{
    public partial class Index
    {
        public RestClient rc;
        public Ai.Insights.V1.Index parent;
        public Index(Ai.Insights.V1.Index parent)
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

namespace RingCentral.Paths.Ai.Insights.V1
{
    public partial class Index
    {
        public Ai.Insights.V1.Async.Index Async()
        {
            return new Ai.Insights.V1.Async.Index(this);
        }
    }
}