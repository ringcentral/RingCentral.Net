using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Webinar.Registration
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
            return $"{parent.Path(false)}/registration";
        }

    }
}

namespace RingCentral.Paths.Webinar
{
    public partial class Index
    {
        public Webinar.Registration.Index Registration()
        {
            return new Webinar.Registration.Index(this);
        }
    }
}