using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Ai.Ringsense.V1.Public.Accounts.Domains
{
    public partial class Index
    {
        public RestClient rc;
public Ai.Ringsense.V1.Public.Accounts.Index parent;
public string domain;
public Index(Ai.Ringsense.V1.Public.Accounts.Index parent, string domain = null)
      {
this.parent = parent;
this.rc = parent.rc;
this.domain = domain;
}
        public string Path(bool withParameter = true)
        {
            if (withParameter && domain != null)
            {
                return $"{parent.Path()}/domains/{domain}";
            }
            return $"{parent.Path()}/domains";
        }

    }
}

namespace RingCentral.Paths.Ai.Ringsense.V1.Public.Accounts
{
    public partial class Index
    {
        public Ai.Ringsense.V1.Public.Accounts.Domains.Index Domains(string domain = null)
        {
            return new Ai.Ringsense.V1.Public.Accounts.Domains.Index(this, domain);
        }
    }
}