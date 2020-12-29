using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.A2pSms.Batch
{
    public partial class Index
    {
        public RestClient rc;
        public string batchId;
        public Restapi.Account.A2pSms.Index parent;

        public Index(Restapi.Account.A2pSms.Index parent, string batchId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.batchId = batchId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && batchId != null)
            {
                return $"{parent.Path()}/batch/{batchId}";
            }

            return $"{parent.Path()}/batch";
        }

        /// <summary>
        /// Operation: Send A2P SMS
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/account/{accountId}/a2p-sms/batch
        /// Rate Limit Group: Light
        /// App Permission: A2PSMS
        /// User Permission: undefined
        /// </summary>
        public async Task<RingCentral.MessageBatchResponse> Post(
            RingCentral.CreateSMSMessageBatchRequest createSMSMessageBatchRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.MessageBatchResponse>(this.Path(false), createSMSMessageBatchRequest, null,
                restRequestConfig);
        }

        /// <summary>
        /// Operation: Get A2P SMS Batch
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/a2p-sms/batch/{batchId}
        /// Rate Limit Group: Light
        /// App Permission: A2PSMS
        /// User Permission: undefined
        /// </summary>
        public async Task<RingCentral.MessageBatchResponse> Get(RestRequestConfig restRequestConfig = null)
        {
            if (this.batchId == null)
            {
                throw new System.ArgumentNullException("batchId");
            }

            return await rc.Get<RingCentral.MessageBatchResponse>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.A2pSms
{
    public partial class Index
    {
        public Restapi.Account.A2pSms.Batch.Index Batch(string batchId = null)
        {
            return new Restapi.Account.A2pSms.Batch.Index(this, batchId);
        }
    }
}