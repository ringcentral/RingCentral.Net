using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.PagingOnlyGroups
{
    public partial class Index
    {
        public RestClient rc;
public Restapi.Account.Index parent;
public string pagingOnlyGroupId;
public Index(Restapi.Account.Index parent, string pagingOnlyGroupId = null)
      {
this.parent = parent;
this.rc = parent.rc;
this.pagingOnlyGroupId = pagingOnlyGroupId;
}
        public string Path(bool withParameter = true)
        {
            if (withParameter && pagingOnlyGroupId != null)
            {
                return $"{parent.Path()}/paging-only-groups/{pagingOnlyGroupId}";
            }
            return $"{parent.Path()}/paging-only-groups";
        }

    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public Restapi.Account.PagingOnlyGroups.Index PagingOnlyGroups(string pagingOnlyGroupId = null)
        {
            return new Restapi.Account.PagingOnlyGroups.Index(this, pagingOnlyGroupId);
        }
    }
}