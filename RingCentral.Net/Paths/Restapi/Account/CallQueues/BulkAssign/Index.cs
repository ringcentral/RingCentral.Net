using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.CallQueues.BulkAssign
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
            return $"{parent.Path()}/bulk-assign";
        }

        // Operation: Edit Call Queue Members
        // Http Post /restapi/v1.0/account/{accountId}/call-queues/{groupId}/bulk-assign
        public async Task<string> Post(RingCentral.CallQueueBulkAssignResource callQueueBulkAssignResource)
        {
            return await rc.Post<string>(this.Path(), callQueueBulkAssignResource);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.CallQueues
{
    public partial class Index
    {
        public Restapi.Account.CallQueues.BulkAssign.Index BulkAssign()
        {
            return new Restapi.Account.CallQueues.BulkAssign.Index(this);
        }
    }
}