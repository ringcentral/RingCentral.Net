namespace RingCentral.Paths.Ai.Ringsense.V1.Public.Accounts.Domains.Records
{
    public partial class Index
    {
        public Domains.Index parent;
        public RestClient rc;
        public string sourceRecordId;

        public Index(Domains.Index parent, string sourceRecordId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.sourceRecordId = sourceRecordId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && sourceRecordId != null) return $"{parent.Path()}/records/{sourceRecordId}";

            return $"{parent.Path()}/records";
        }
    }
}

namespace RingCentral.Paths.Ai.Ringsense.V1.Public.Accounts.Domains
{
    public partial class Index
    {
        public Records.Index Records(string sourceRecordId = null)
        {
            return new Records.Index(this, sourceRecordId);
        }
    }
}