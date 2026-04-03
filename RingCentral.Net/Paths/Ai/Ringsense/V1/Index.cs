using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Ai.Ringsense.V1
{
    public partial class Index
    {
        public RestClient rc;
        public Ai.Ringsense.Index parent;
        public Index(Ai.Ringsense.Index parent)
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

namespace RingCentral.Paths.Ai.Ringsense
{
    public partial class Index
    {
        public Ai.Ringsense.V1.Index V1()
        {
            return new Ai.Ringsense.V1.Index(this);
        }
    }
}