using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.V2
{
    public partial class Index
    {
        public RestClient rc;
public Restapi.Index parent;
public Index(Restapi.Index parent)
      {
this.parent = parent;
this.rc = parent.rc;
}
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path(false)}/v2";
        }

    }
}

namespace RingCentral.Paths.Restapi
{
    public partial class Index
    {
        public Restapi.V2.Index V2()
        {
            return new Restapi.V2.Index(this);
        }
    }
}