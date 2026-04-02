using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Analytics.Calls
{
    public partial class Index
    {
        public RestClient rc;
public Analytics.Index parent;
public Index(Analytics.Index parent)
      {
this.parent = parent;
this.rc = parent.rc;
}
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path(false)}/calls";
        }

    }
}

namespace RingCentral.Paths.Analytics
{
    public partial class Index
    {
        public Analytics.Calls.Index Calls()
        {
            return new Analytics.Calls.Index(this);
        }
    }
}