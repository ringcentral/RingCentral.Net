using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Ai.Insights.V1
{
    public partial class Index
    {
        public RestClient rc;
        public Ai.Insights.Index parent;
        public Index(Ai.Insights.Index parent)
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

namespace RingCentral.Paths.Ai.Insights
{
    public partial class Index
    {
        public Ai.Insights.V1.Index V1()
        {
            return new Ai.Insights.V1.Index(this);
        }
    }
}