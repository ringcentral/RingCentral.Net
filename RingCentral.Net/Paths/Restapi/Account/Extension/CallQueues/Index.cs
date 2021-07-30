using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.Extension.CallQueues
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Extension.Index parent;

        public Index(Restapi.Account.Extension.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/call-queues";
        }

        /// <summary>
        /// Updates the list of call queues where the user is an agent. This is a full update request, which means that if any queue where the user is an agent is not mentioned in request, then the user is automatically removed from this queue.
        /// HTTP Method: put
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/call-queues
        /// Rate Limit Group: Medium
        /// App Permission: EditAccounts
        /// User Permission: JoinLeaveCallQueue
        /// </summary>
        public async Task<RingCentral.UserCallQueues> Put(RingCentral.UserCallQueues userCallQueues,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Put<RingCentral.UserCallQueues>(this.Path(), userCallQueues, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.CallQueues.Index CallQueues()
        {
            return new Restapi.Account.Extension.CallQueues.Index(this);
        }
    }
}