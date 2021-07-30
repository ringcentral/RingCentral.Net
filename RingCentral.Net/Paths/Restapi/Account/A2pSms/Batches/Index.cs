using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.A2pSms.Batches
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
                return $"{parent.Path()}/batches/{batchId}";
            }

            return $"{parent.Path()}/batches";
        }

        /// <summary>
        /// Returns the list of A2P batches sent from the current account. The list can be filtered by message batch ID and/or from phone number.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/a2p-sms/batches
        /// Rate Limit Group: Light
        /// App Permission: A2PSMS
        /// </summary>
        public async Task<RingCentral.MessageBatchListResponse> List(
            RingCentral.ListA2PBatchesParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.MessageBatchListResponse>(this.Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        /// Allows to send high volume of A2P (Application-to-Person) SMS messages (in message batches). Only phone number with the `A2PSmsSender` feature can be used as a sender.
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/a2p-sms/batches
        /// Rate Limit Group: Light
        /// App Permission: A2PSMS
        /// </summary>
        public async Task<RingCentral.MessageBatchInfo> Post(
            RingCentral.CreateSMSMessageBatchRequest createSMSMessageBatchRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.MessageBatchInfo>(this.Path(false), createSMSMessageBatchRequest, null,
                restRequestConfig);
        }

        /// <summary>
        /// Returns information on a message batch.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/a2p-sms/batches/{batchId}
        /// Rate Limit Group: Light
        /// App Permission: A2PSMS
        /// </summary>
        public async Task<RingCentral.MessageBatchInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            if (batchId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(batchId));
            }

            return await rc.Get<RingCentral.MessageBatchInfo>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.A2pSms
{
    public partial class Index
    {
        public Restapi.Account.A2pSms.Batches.Index Batches(string batchId = null)
        {
            return new Restapi.Account.A2pSms.Batches.Index(this, batchId);
        }
    }
}