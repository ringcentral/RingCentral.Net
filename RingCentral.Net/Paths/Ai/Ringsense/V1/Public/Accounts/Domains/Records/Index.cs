using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Ai.Ringsense.V1.Public.Accounts.Domains.Records
{
    public partial class Index
    {
        public RestClient rc;
public Ai.Ringsense.V1.Public.Accounts.Domains.Index parent;
public string sourceRecordId;
public Index(Ai.Ringsense.V1.Public.Accounts.Domains.Index parent, string sourceRecordId = null)
      {
this.parent = parent;
this.rc = parent.rc;
this.sourceRecordId = sourceRecordId;
}
        public string Path(bool withParameter = true)
        {
            if (withParameter && sourceRecordId != null)
            {
                return $"{parent.Path()}/records/{sourceRecordId}";
            }
            return $"{parent.Path()}/records";
        }

    }
}

namespace RingCentral.Paths.Ai.Ringsense.V1.Public.Accounts.Domains
{
    public partial class Index
    {
        public Ai.Ringsense.V1.Public.Accounts.Domains.Records.Index Records(string sourceRecordId = null)
        {
            return new Ai.Ringsense.V1.Public.Accounts.Domains.Records.Index(this, sourceRecordId);
        }
    }
}