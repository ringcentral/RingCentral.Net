using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Account.CallQueues
{
    public partial class Index
    {
        public RestClient rc;
        public string groupId;
        public Restapi.Account.Index parent;

        public Index(Restapi.Account.Index parent, string groupId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.groupId = groupId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && groupId != null)
            {
                return $"{parent.Path()}/call-queues/{groupId}";
            }

            return $"{parent.Path()}/call-queues";
        }

        /// <summary>
        /// Operation: Get Call Queue List
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/call-queues
        /// Rate Limit Group: Medium
        /// App Permission: ReadAccounts
        /// User Permission: ReadExtensions
        /// </summary>
        public async Task<RingCentral.CallQueues> List(ListCallQueuesParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.CallQueues>(this.Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        /// Operation: Get Call Queue
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/call-queues/{groupId}
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// User Permission: ReadExtensions
        /// </summary>
        public async Task<RingCentral.CallQueueDetails> Get(RestRequestConfig restRequestConfig = null)
        {
            if (this.groupId == null)
            {
                throw new System.ArgumentNullException("groupId");
            }

            return await rc.Get<RingCentral.CallQueueDetails>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Operation: Update Call Queue
        /// HTTP Method: PUT
        /// Endpoint: /restapi/v1.0/account/{accountId}/call-queues/{groupId}
        /// Rate Limit Group: Light
        /// App Permission: EditExtensions
        /// User Permission: EditUserInfo
        /// </summary>
        public async Task<RingCentral.CallQueueDetails> Put(RingCentral.CallQueueUpdateDetails callQueueUpdateDetails,
            RestRequestConfig restRequestConfig = null)
        {
            if (this.groupId == null)
            {
                throw new System.ArgumentNullException("groupId");
            }

            return await rc.Put<RingCentral.CallQueueDetails>(this.Path(), callQueueUpdateDetails, null,
                restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public Restapi.Account.CallQueues.Index CallQueues(string groupId = null)
        {
            return new Restapi.Account.CallQueues.Index(this, groupId);
        }
    }
}