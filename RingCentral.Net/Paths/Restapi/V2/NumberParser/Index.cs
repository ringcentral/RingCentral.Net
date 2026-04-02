using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.V2.NumberParser
{
    public partial class Index
    {
        public RestClient rc;
public Restapi.V2.Index parent;
public Index(Restapi.V2.Index parent)
      {
this.parent = parent;
this.rc = parent.rc;
}
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path(false)}/number-parser";
        }

    }
}

namespace RingCentral.Paths.Restapi.V2
{
    public partial class Index
    {
        public Restapi.V2.NumberParser.Index NumberParser()
        {
            return new Restapi.V2.NumberParser.Index(this);
        }
    }
}