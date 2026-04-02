using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Ai.Ringsense.V1.Public.Accounts.Domains.Sessions
{
    public partial class Index
    {
        public RestClient rc;
public Ai.Ringsense.V1.Public.Accounts.Domains.Index parent;
public string sourceSessionId;
public Index(Ai.Ringsense.V1.Public.Accounts.Domains.Index parent, string sourceSessionId = null)
      {
this.parent = parent;
this.rc = parent.rc;
this.sourceSessionId = sourceSessionId;
}
        public string Path(bool withParameter = true)
        {
            if (withParameter && sourceSessionId != null)
            {
                return $"{parent.Path()}/sessions/{sourceSessionId}";
            }
            return $"{parent.Path()}/sessions";
        }

    }
}

namespace RingCentral.Paths.Ai.Ringsense.V1.Public.Accounts.Domains
{
    public partial class Index
    {
        public Ai.Ringsense.V1.Public.Accounts.Domains.Sessions.Index Sessions(string sourceSessionId = null)
        {
            return new Ai.Ringsense.V1.Public.Accounts.Domains.Sessions.Index(this, sourceSessionId);
        }
    }
}