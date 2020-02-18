using System.Threading.Tasks;

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
        /// Operation: Get Call Queues
        /// Http Get /restapi/v1.0/account/{accountId}/call-queues
        /// </summary>
        public async Task<RingCentral.CallQueues> List(ListCallQueuesParameters queryParams = null)
        {
            return await rc.Get<RingCentral.CallQueues>(this.Path(false), queryParams);
        }

        /// <summary>
        /// Operation: Get Call Queue
        /// Http Get /restapi/v1.0/account/{accountId}/call-queues/{groupId}
        /// </summary>
        public async Task<RingCentral.CallQueueDetails> Get()
        {
            if (this.groupId == null)
            {
                throw new System.ArgumentNullException("groupId");
            }

            return await rc.Get<RingCentral.CallQueueDetails>(this.Path());
        }

        /// <summary>
        /// Operation: Update Call Queue
        /// Http Put /restapi/v1.0/account/{accountId}/call-queues/{groupId}
        /// </summary>
        public async Task<RingCentral.CallQueueDetails> Put(RingCentral.CallQueueUpdateDetails callQueueUpdateDetails)
        {
            if (this.groupId == null)
            {
                throw new System.ArgumentNullException("groupId");
            }

            return await rc.Put<RingCentral.CallQueueDetails>(this.Path(), callQueueUpdateDetails);
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