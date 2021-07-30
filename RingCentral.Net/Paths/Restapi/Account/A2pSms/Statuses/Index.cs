using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.A2pSms.Statuses
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.A2pSms.Index parent;

        public Index(Restapi.Account.A2pSms.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/statuses";
        }

        /// <summary>
        /// Retrieves a set of message counts by message status and error codes filtered by dates, batchId and message direction.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/a2p-sms/statuses
        /// Rate Limit Group: Light
        /// App Permission: A2PSMS
        /// </summary>
        public async Task<RingCentral.MessageStatusesResponse> Get(
            RingCentral.AggregateA2PSMSStatusesParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.MessageStatusesResponse>(this.Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.A2pSms
{
    public partial class Index
    {
        public Restapi.Account.A2pSms.Statuses.Index Statuses()
        {
            return new Restapi.Account.A2pSms.Statuses.Index(this);
        }
    }
}