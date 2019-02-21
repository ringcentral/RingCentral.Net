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

        public async Task<RingCentral.CallQueueMembers> Get(ListCallQueueMembersParameters queryParams = null)
        {
            return await rc.Get<RingCentral.CallQueueMembers>(this.Path(), queryParams);
        }
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