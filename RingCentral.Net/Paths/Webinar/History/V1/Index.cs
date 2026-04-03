using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Webinar.History.V1
{
    public partial class Index
    {
        public RestClient rc;
        public Webinar.History.Index parent;
        public Index(Webinar.History.Index parent)
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

namespace RingCentral.Paths.Webinar.History
{
    public partial class Index
    {
        public Webinar.History.V1.Index V1()
        {
            return new Webinar.History.V1.Index(this);
        }
    }
}