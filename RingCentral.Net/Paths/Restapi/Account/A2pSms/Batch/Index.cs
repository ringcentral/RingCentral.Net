using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.A2pSms.Batch
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.A2pSms.Index parent;
        public string batchId;

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
        /// Allows to send high volume of A2P (Application-to-Person) SMS messages (in message batches). Only phone number with the `A2PSmsSender` feature can be used as a sender.
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/a2p-sms/batch
        /// Rate Limit Group: Light
        /// App Permission: A2PSMS
        /// </summary>
        public async Task<RingCentral.CreateMessageBatchResponse> Post(
            RingCentral.CreateSMSMessageBatchRequest createSMSMessageBatchRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.CreateMessageBatchResponse>(this.Path(false), createSMSMessageBatchRequest,
                null, restRequestConfig);
        }

        /// <summary>
        /// Returns information on a message batch.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/a2p-sms/batch/{batchId}
        /// Rate Limit Group: Light
        /// App Permission: A2PSMS
        /// </summary>
        public async Task<RingCentral.MessageBatchResponse> Get(RestRequestConfig restRequestConfig = null)
        {
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