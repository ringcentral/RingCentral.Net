using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.MessageThreads.Entries.Sync
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.MessageThreads.Entries.Index parent;
        public Index(Restapi.Account.MessageThreads.Entries.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/sync";
        }
        /// <summary>
        /// Synchronizes the list of thread entries. The response may contain:
        /// - added or updated messages (full payload);
        /// - added or updated notes (full payload);
        /// - deleted message entries (limited attributes, `availability` is set to `Deleted`);
        /// - deleted note entries (limited attributes, `availability` is set to `Deleted`);
        /// - system entries (`action` describes the action performed).
        /// 
        /// In `FSync` model:
        /// - only `Alive` messages and notes are returned;
        /// - only messages and notes from `Open` threads are returned (unless explicit `threadIds` are requested).
        /// 
        /// The records are sorted by `lastModifiedTime` in descending order.
        /// 
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/message-threads/entries/sync
        /// Rate Limit Group: Medium
        /// App Permission: SMS
        /// </summary>
        public async Task<RingCentral.ThreadEntriesSyncList> Get(RingCentral.MthSyncEntriesParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.ThreadEntriesSyncList>(this.Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.MessageThreads.Entries
{
    public partial class Index
    {
        public Restapi.Account.MessageThreads.Entries.Sync.Index Sync()
        {
            return new Restapi.Account.MessageThreads.Entries.Sync.Index(this);
        }
    }
}