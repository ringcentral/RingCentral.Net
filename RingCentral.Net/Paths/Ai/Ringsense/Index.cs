using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Ai.Ringsense
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
            return $"{parent.Path(false)}/ringsense";
        }

    }
}

namespace RingCentral.Paths.Ai
{
    public partial class Index
    {
        public Ai.Ringsense.Index Ringsense()
        {
            return new Ai.Ringsense.Index(this);
        }
    }
}