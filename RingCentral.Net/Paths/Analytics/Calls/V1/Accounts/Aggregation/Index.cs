using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Analytics.Calls.V1.Accounts.Aggregation
{
    public partial class Index
    {
        public RestClient rc;
public Analytics.Calls.V1.Accounts.Index parent;
public Index(Analytics.Calls.V1.Accounts.Index parent)
      {
this.parent = parent;
this.rc = parent.rc;
}
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/aggregation";
        }

    }
}

namespace RingCentral.Paths.Analytics.Calls.V1.Accounts
{
    public partial class Index
    {
        public Analytics.Calls.V1.Accounts.Aggregation.Index Aggregation()
        {
            return new Analytics.Calls.V1.Accounts.Aggregation.Index(this);
        }
    }
}