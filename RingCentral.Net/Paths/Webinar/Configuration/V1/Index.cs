using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Webinar.Configuration.V1
{
    public partial class Index
    {
        public RestClient rc;
public Webinar.Configuration.Index parent;
public Index(Webinar.Configuration.Index parent)
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

namespace RingCentral.Paths.Webinar.Configuration
{
    public partial class Index
    {
        public Webinar.Configuration.V1.Index V1()
        {
            return new Webinar.Configuration.V1.Index(this);
        }
    }
}