using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.CallQueues
{
    public class Index
    {
        public Extension.Index parent;
        public RestClient rc;

        public Index(Extension.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/call-queues";
        }

        /// <summary>
        ///     Updates a list of call queues where the user is an agent. This
        ///     is a full update request, which means that if any call queue where the user is
        ///     an agent is not mentioned in request, then the user is automatically removed
        ///     from this queue.
        ///     HTTP Method: put
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/call-queues
        ///     Rate Limit Group: Medium
        ///     App Permission: EditAccounts
        ///     User Permission: EditCallQueuePresence
        /// </summary>
        public async Task<UserCallQueues> Put(UserCallQueues userCallQueues,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Put<UserCallQueues>(Path(), userCallQueues, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public CallQueues.Index CallQueues()
        {
            return new CallQueues.Index(this);
        }
    }
}