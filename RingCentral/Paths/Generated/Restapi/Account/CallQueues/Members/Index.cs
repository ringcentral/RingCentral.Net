using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.CallQueues.Members
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.CallQueues.Index parent;

        public Index(Restapi.Account.CallQueues.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/members";
        }

        public async Task<RingCentral.CallQueueMembers> Get(GetQueryParams queryParams = null)
        {
            return await rc.Get<RingCentral.CallQueueMembers>(this.Path(), queryParams);
        }

        public async Task<RingCentral.CallQueueMembers> Get(object queryParams)
        {
            return await rc.Get<RingCentral.CallQueueMembers>(this.Path(), queryParams);
        }
    }

    public class GetQueryParams
    {
        // Indicates the page number to retrieve. Only positive number values are allowed
        public long? page;

        // Indicates the page size (number of items)
        public long? perPage;
    }
}

namespace RingCentral.Paths.Restapi.Account.CallQueues
{
    public partial class Index
    {
        public Restapi.Account.CallQueues.Members.Index Members()
        {
            return new Restapi.Account.CallQueues.Members.Index(this);
        }
    }
}