namespace RingCentral.Paths.Ai.Ringsense.V1.Public.Accounts.Domains.Sessions
{
    public partial class Index
    {
        public Domains.Index parent;
        public RestClient rc;
        public string sourceSessionId;

        public Index(Domains.Index parent, string sourceSessionId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.sourceSessionId = sourceSessionId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && sourceSessionId != null) return $"{parent.Path()}/sessions/{sourceSessionId}";
            return $"{parent.Path()}/sessions";
        }
    }
}

namespace RingCentral.Paths.Ai.Ringsense.V1.Public.Accounts.Domains
{
    public partial class Index
    {
        public Sessions.Index Sessions(string sourceSessionId = null)
        {
            return new Sessions.Index(this, sourceSessionId);
        }
    }
}