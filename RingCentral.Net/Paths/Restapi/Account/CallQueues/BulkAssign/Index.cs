using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

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
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/bulk-assign";
        }
        /// <summary>
        /// Assigns multiple call queue members to call queue group.
        /// 
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/call-queues/{groupId}/bulk-assign
        /// Rate Limit Group: Heavy
        /// App Permission: EditExtensions
        /// User Permission: Groups
        /// </summary>
        public async Task<string> Post(RingCentral.CallQueueBulkAssignResource callQueueBulkAssignResource, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<string>(this.Path(), callQueueBulkAssignResource, null, restRequestConfig);
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