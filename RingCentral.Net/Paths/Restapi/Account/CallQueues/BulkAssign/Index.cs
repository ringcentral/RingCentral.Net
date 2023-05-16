using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.CallQueues.BulkAssign
{
    public class Index
    {
        public CallQueues.Index parent;
        public RestClient rc;

        public Index(CallQueues.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/bulk-assign";
        }

        /// <summary>
        ///     Assigns multiple call queue members to call queue group.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/call-queues/{groupId}/bulk-assign
        ///     Rate Limit Group: Heavy
        ///     App Permission: EditExtensions
        ///     User Permission: Groups
        /// </summary>
        public async Task<string> Post(CallQueueBulkAssignResource callQueueBulkAssignResource,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<string>(Path(), callQueueBulkAssignResource, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.CallQueues
{
    public partial class Index
    {
        public BulkAssign.Index BulkAssign()
        {
            return new BulkAssign.Index(this);
        }
    }
}