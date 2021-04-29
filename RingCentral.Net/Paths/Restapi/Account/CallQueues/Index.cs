using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.CallQueues
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Index parent;
        public string groupId;

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
        /// Returns call queue group list.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/call-queues
        /// Rate Limit Group: Medium
        /// App Permission: ReadAccounts
        /// User Permission: ReadExtensions
        /// </summary>
        public async Task<RingCentral.CallQueues> List(RingCentral.ListCallQueuesParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.CallQueues>(this.Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        /// Returns basic information on a call queue group extension.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/call-queues/{groupId}
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// User Permission: ReadExtensions
        /// </summary>
        public async Task<RingCentral.CallQueueDetails> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.CallQueueDetails>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Updates information on a call queue group extension.
        /// HTTP Method: put
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/call-queues/{groupId}
        /// Rate Limit Group: Light
        /// App Permission: EditExtensions
        /// User Permission: EditUserInfo
        /// </summary>
        public async Task<RingCentral.CallQueueDetails> Put(RingCentral.CallQueueUpdateDetails callQueueUpdateDetails,
            RestRequestConfig restRequestConfig = null)
        {
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