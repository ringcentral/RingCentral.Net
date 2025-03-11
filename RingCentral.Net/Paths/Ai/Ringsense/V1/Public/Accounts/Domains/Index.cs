namespace RingCentral.Paths.Ai.Ringsense.V1.Public.Accounts.Domains
{
    public partial class Index
    {
        public string domain;
        public Accounts.Index parent;
        public RestClient rc;

        public Index(Accounts.Index parent, string domain = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.domain = domain;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && domain != null) return $"{parent.Path()}/domains/{domain}";
            return $"{parent.Path()}/domains";
        }
    }
}

namespace RingCentral.Paths.Ai.Ringsense.V1.Public.Accounts
{
    public partial class Index
    {
        public Domains.Index Domains(string domain = null)
        {
            return new Domains.Index(this, domain);
        }
    }
}