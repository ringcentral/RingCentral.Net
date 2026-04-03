using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Analytics.Calls.V1
{
    public partial class Index
    {
        public RestClient rc;
        public Analytics.Calls.Index parent;
        public Index(Analytics.Calls.Index parent)
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

namespace RingCentral.Paths.Analytics.Calls
{
    public partial class Index
    {
        public Analytics.Calls.V1.Index V1()
        {
            return new Analytics.Calls.V1.Index(this);
        }
    }
}