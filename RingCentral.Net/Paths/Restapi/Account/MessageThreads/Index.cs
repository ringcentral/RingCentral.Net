using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.MessageThreads
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Index parent;
        public string threadId;
        public Index(Restapi.Account.Index parent, string threadId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.threadId = threadId;
        }
        public string Path(bool withParameter = true)
        {
            if (withParameter && threadId != null)
            {
                return $"{parent.Path()}/message-threads/{threadId}";
            }
            return $"{parent.Path()}/message-threads";
        }
        /// <summary>
        /// Returns a paginated list of message threads for the specified account according to the specified criteria.
        /// 
        /// Different filters are combined with logical "AND", different values for the same filter (if supported)
        /// are combined with logical "OR".
        /// 
        /// Only threads that accessible for a current authorized user are returned.
        /// The records are sorted by `creationTime` in ascending order.
        /// 
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/message-threads
        /// Rate Limit Group: Medium
        /// App Permission: SMS
        /// </summary>
        public async Task<RingCentral.MessageThreadList> List(RingCentral.MthListThreadsParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.MessageThreadList>(this.Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        /// Returns a message thread by ID.
        /// 
        /// API returns a 403 error if the current user does not have access to the given thread.
        /// 
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/message-threads/{threadId}
        /// Rate Limit Group: Medium
        /// App Permission: SMS
        /// </summary>
        public async Task<RingCentral.MessageThread> Get(RestRequestConfig restRequestConfig = null)
        {
            if (threadId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(threadId));
            }
            return await rc.Get<RingCentral.MessageThread>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Deletes a message thread by IDs.
        /// 
        /// Technically this operation just sets thread's `availability` to `Deleted`.
        /// API returns a 403 error if the current user does not have access to the given thread.
        /// 
        /// Once the thread is deleted its `assignee` attribute is cleared automatically.
        /// 
        /// HTTP Method: delete
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/message-threads/{threadId}
        /// Rate Limit Group: Medium
        /// App Permission: SMS
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            if (threadId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(threadId));
            }
            return await rc.Delete<string>(this.Path(), null, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public Restapi.Account.MessageThreads.Index MessageThreads(string threadId = null)
        {
            return new Restapi.Account.MessageThreads.Index(this, threadId);
        }
    }
}