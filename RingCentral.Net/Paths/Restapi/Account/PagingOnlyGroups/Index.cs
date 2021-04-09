namespace RingCentral.Paths.Restapi.Account.PagingOnlyGroups
{
    public partial class Index
    {
        public Account.Index parent;
        public RestClient rc;

        public Index(Account.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/paging-only-groups";
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public PagingOnlyGroups.Index PagingOnlyGroups()
        {
            return new PagingOnlyGroups.Index(this);
        }
    }
}