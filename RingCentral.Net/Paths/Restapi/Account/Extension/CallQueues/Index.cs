using System.Threading.Tasks;
using System.Threading;

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
        /// Operation: Update User Call Queues
        /// HTTP Method: PUT
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/call-queues
        /// Rate Limit Group: Medium
        /// App Permission: Accounts
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