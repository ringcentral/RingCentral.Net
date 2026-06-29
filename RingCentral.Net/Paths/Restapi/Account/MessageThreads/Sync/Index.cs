using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.MessageThreads.Sync
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.MessageThreads.Index parent;
        public Index(Restapi.Account.MessageThreads.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/sync";
        }
        /// <summary>
        /// Synchronizes the list of message threads.
        /// Returns the thread records that the current user can monitor
        /// (assigned to current user, assigned to other users or unassigned).
        /// 
        /// In `FSync` mode, only `Open` and `Alive`threads are returned.
        /// The records are sorted by `lastModifiedTime` in descending order.
        /// 
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/message-threads/sync
        /// Rate Limit Group: Medium
        /// App Permission: SMS
        /// </summary>
        public async Task<RingCentral.ThreadSyncList> Get(RingCentral.MthSyncThreadsParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.ThreadSyncList>(this.Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.MessageThreads
{
    public partial class Index
    {
        public Restapi.Account.MessageThreads.Sync.Index Sync()
        {
            return new Restapi.Account.MessageThreads.Sync.Index(this);
        }
    }
}