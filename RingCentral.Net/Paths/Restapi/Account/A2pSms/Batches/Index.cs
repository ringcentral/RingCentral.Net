using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.A2pSms.Batches
{
    public class Index
    {
        public string batchId;
        public A2pSms.Index parent;
        public RestClient rc;

        public Index(A2pSms.Index parent, string batchId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.batchId = batchId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && batchId != null) return $"{parent.Path()}/batches/{batchId}";

            return $"{parent.Path()}/batches";
        }

        /// <summary>
        ///     Returns the list of A2P batches sent from the current account. The list can be filtered by message batch ID and/or
        ///     from phone number.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/a2p-sms/batches
        ///     Rate Limit Group: Light
        ///     App Permission: A2PSMS
        /// </summary>
        public async Task<MessageBatchListResponse> List(
            ListA2PBatchesParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<MessageBatchListResponse>(Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Allows to send high volume of A2P (Application-to-Person) SMS messages (in message batches). Only phone number with
        ///     the `A2PSmsSender` feature can be used as a sender.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/a2p-sms/batches
        ///     Rate Limit Group: Light
        ///     App Permission: A2PSMS
        /// </summary>
        public async Task<MessageBatchInfo> Post(
            CreateSMSMessageBatchRequest createSMSMessageBatchRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<MessageBatchInfo>(Path(false), createSMSMessageBatchRequest, null,
                restRequestConfig);
        }

        /// <summary>
        ///     Returns information on a message batch.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/a2p-sms/batches/{batchId}
        ///     Rate Limit Group: Light
        ///     App Permission: A2PSMS
        /// </summary>
        public async Task<MessageBatchInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            if (batchId == null) throw new ArgumentException("Parameter cannot be null", nameof(batchId));

            return await rc.Get<MessageBatchInfo>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.A2pSms
{
    public partial class Index
    {
        public Batches.Index Batches(string batchId = null)
        {
            return new Batches.Index(this, batchId);
        }
    }
}