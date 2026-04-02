using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Webinar.History.V1.Company
{
    public partial class Index
    {
        public RestClient rc;
public Webinar.History.V1.Index parent;
public Index(Webinar.History.V1.Index parent)
      {
this.parent = parent;
this.rc = parent.rc;
}
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path(false)}/company";
        }

    }
}

namespace RingCentral.Paths.Webinar.History.V1
{
    public partial class Index
    {
        public Webinar.History.V1.Company.Index Company()
        {
            return new Webinar.History.V1.Company.Index(this);
        }
    }
}