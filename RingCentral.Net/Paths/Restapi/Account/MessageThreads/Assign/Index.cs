using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.MessageThreads.Assign
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
            return $"{parent.Path()}/assign";
        }
        /// <summary>
        /// Assigns, unassigns, or reassigns the thread.
        /// The authorized user must be in the list of thread monitors, otherwise the API returns a 403 error.
        /// 
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/message-threads/{threadId}/assign
        /// Rate Limit Group: Medium
        /// App Permission: SMS
        /// </summary>
        public async Task<RingCentral.MessageThread> Post(RingCentral.AssignMessageThreadRequest assignMessageThreadRequest, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.MessageThread>(this.Path(), assignMessageThreadRequest, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.MessageThreads
{
    public partial class Index
    {
        public Restapi.Account.MessageThreads.Assign.Index Assign()
        {
            return new Restapi.Account.MessageThreads.Assign.Index(this);
        }
    }
}