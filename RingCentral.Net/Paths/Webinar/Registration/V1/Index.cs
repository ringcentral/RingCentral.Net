using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Webinar.Registration.V1
{
    public partial class Index
    {
        public RestClient rc;
        public Webinar.Registration.Index parent;
        public Index(Webinar.Registration.Index parent)
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

namespace RingCentral.Paths.Webinar.Registration
{
    public partial class Index
    {
        public Webinar.Registration.V1.Index V1()
        {
            return new Webinar.Registration.V1.Index(this);
        }
    }
}