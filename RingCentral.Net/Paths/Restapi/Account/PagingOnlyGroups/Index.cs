namespace RingCentral.Paths.Restapi.Account.PagingOnlyGroups
{
    public partial class Index
    {
        public string pagingOnlyGroupId;
        public Account.Index parent;
        public RestClient rc;

        public Index(Account.Index parent, string pagingOnlyGroupId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.pagingOnlyGroupId = pagingOnlyGroupId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && pagingOnlyGroupId != null)
                return $"{parent.Path()}/paging-only-groups/{pagingOnlyGroupId}";

            return $"{parent.Path()}/paging-only-groups";
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public PagingOnlyGroups.Index PagingOnlyGroups(string pagingOnlyGroupId = null)
        {
            return new PagingOnlyGroups.Index(this, pagingOnlyGroupId);
        }
    }
}