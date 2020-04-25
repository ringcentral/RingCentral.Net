using System.Threading.Tasks;
using System.Threading;

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

        /// <summary>
        /// Operation: Assign Multiple Call Queue Members
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/account/{accountId}/call-queues/{groupId}/bulk-assign
        /// Rate Limit Group: Heavy
        /// App Permission: EditExtensions
        /// User Permission: Groups
        /// </summary>
        public async Task<string> Post(RingCentral.CallQueueBulkAssignResource callQueueBulkAssignResource,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Post<string>(this.Path(), callQueueBulkAssignResource, null, cancellationToken);
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