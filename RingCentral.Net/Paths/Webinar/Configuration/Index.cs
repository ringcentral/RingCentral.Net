using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Webinar.Configuration
{
    public partial class Index
    {
        public RestClient rc;
        public Webinar.Index parent;
        public Index(Webinar.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path(false)}/configuration";
        }

    }
}

namespace RingCentral.Paths.Webinar
{
    public partial class Index
    {
        public Webinar.Configuration.Index Configuration()
        {
            return new Webinar.Configuration.Index(this);
        }
    }
}