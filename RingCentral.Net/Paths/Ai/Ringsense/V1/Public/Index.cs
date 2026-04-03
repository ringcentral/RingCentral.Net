using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Ai.Ringsense.V1.Public
{
    public partial class Index
    {
        public RestClient rc;
        public Ai.Ringsense.V1.Index parent;
        public Index(Ai.Ringsense.V1.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path(false)}/public";
        }

    }
}

namespace RingCentral.Paths.Ai.Ringsense.V1
{
    public partial class Index
    {
        public Ai.Ringsense.V1.Public.Index Public()
        {
            return new Ai.Ringsense.V1.Public.Index(this);
        }
    }
}