using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Webinar.Configuration.V1.Company
{
    public partial class Index
    {
        public RestClient rc;
        public Webinar.Configuration.V1.Index parent;
        public Index(Webinar.Configuration.V1.Index parent)
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

namespace RingCentral.Paths.Webinar.Configuration.V1
{
    public partial class Index
    {
        public Webinar.Configuration.V1.Company.Index Company()
        {
            return new Webinar.Configuration.V1.Company.Index(this);
        }
    }
}