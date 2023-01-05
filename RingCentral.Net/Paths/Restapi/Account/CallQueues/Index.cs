using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.CallQueues
{
    public partial class Index
    {
        public string groupId;
        public Account.Index parent;
        public RestClient rc;

        public Index(Account.Index parent, string groupId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.groupId = groupId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && groupId != null) return $"{parent.Path()}/call-queues/{groupId}";
            return $"{parent.Path()}/call-queues";
        }

        /// <summary>
        ///     Returns call queues list.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/call-queues
        ///     Rate Limit Group: Medium
        ///     App Permission: ReadAccounts
        ///     User Permission: ReadExtensions
        /// </summary>
        public async Task<RingCentral.CallQueues> List(ListCallQueuesParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.CallQueues>(Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Returns basic information on a call queue group extension.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/call-queues/{groupId}
        ///     Rate Limit Group: Light
        ///     App Permission: ReadAccounts
        ///     User Permission: ReadExtensions
        /// </summary>
        public async Task<CallQueueDetails> Get(RestRequestConfig restRequestConfig = null)
        {
            if (groupId == null) throw new ArgumentException("Parameter cannot be null", nameof(groupId));
            return await rc.Get<CallQueueDetails>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Updates information on a call queue group extension.
        ///     HTTP Method: put
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/call-queues/{groupId}
        ///     Rate Limit Group: Light
        ///     App Permission: EditExtensions
        ///     User Permission: EditUserInfo
        /// </summary>
        public async Task<CallQueueDetails> Put(CallQueueUpdateDetails callQueueUpdateDetails,
            RestRequestConfig restRequestConfig = null)
        {
            if (groupId == null) throw new ArgumentException("Parameter cannot be null", nameof(groupId));
            return await rc.Put<CallQueueDetails>(Path(), callQueueUpdateDetails, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public CallQueues.Index CallQueues(string groupId = null)
        {
            return new CallQueues.Index(this, groupId);
        }
    }
}