using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.MessageThreads.Resolve
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
            return $"{parent.Path()}/resolve";
        }
        /// <summary>
        /// Resolves a message thread (sets the status to `Resolved`).
        /// The current status of the thread must be `Open` for this operation to succeed.
        /// The authorized user must be in the list of thread monitors, otherwise the API returns a 403 error.
        /// 
        /// Once the thread is resolved its `assignee` attribute is cleared automatically.
        /// 
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/message-threads/{threadId}/resolve
        /// Rate Limit Group: Medium
        /// App Permission: SMS
        /// </summary>
        public async Task<RingCentral.MessageThread> Post(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.MessageThread>(this.Path(), null, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.MessageThreads
{
    public partial class Index
    {
        public Restapi.Account.MessageThreads.Resolve.Index Resolve()
        {
            return new Restapi.Account.MessageThreads.Resolve.Index(this);
        }
    }
}