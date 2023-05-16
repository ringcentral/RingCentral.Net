namespace RingCentral.Paths.Restapi.V2.Accounts.BatchProvisioning
{
    public partial class Index
    {
        public Accounts.Index parent;
        public RestClient rc;

        public Index(Accounts.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/batch-provisioning";
        }
    }
}

namespace RingCentral.Paths.Restapi.V2.Accounts
{
    public partial class Index
    {
        public BatchProvisioning.Index BatchProvisioning()
        {
            return new BatchProvisioning.Index(this);
        }
    }
}