using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.A2pSms.Statuses
{
    public class Index
    {
        public A2pSms.Index parent;
        public RestClient rc;

        public Index(A2pSms.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/statuses";
        }

        /// <summary>
        ///     Retrieves a set of message counts by message status and error codes filtered by dates, batchId and message
        ///     direction.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/a2p-sms/statuses
        ///     Rate Limit Group: Light
        ///     App Permission: A2PSMS
        /// </summary>
        public async Task<MessageStatusesResponse> Get(AggregateA2PSMSStatusesParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<MessageStatusesResponse>(Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.A2pSms
{
    public partial class Index
    {
        public Statuses.Index Statuses()
        {
            return new Statuses.Index(this);
        }
    }
}