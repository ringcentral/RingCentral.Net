using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.MessageStoreReport
{
    public partial class Index
    {
        public RestClient rc;
        public string taskId;
        public Restapi.Account.Index parent;

        public Index(Restapi.Account.Index parent, string taskId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.taskId = taskId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && taskId != null)
            {
                return $"{parent.Path()}/message-store-report/{taskId}";
            }

            return $"{parent.Path()}/message-store-report";
        }

        /// <summary>
        /// Creates a task to collect all account messages within the specified time interval. Maximum number of simaltaneous tasks per account is 2.
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/account/{accountId}/message-store-report
        /// Rate Limit Group: Heavy
        /// App Permission: ReadMessages
        /// User Permission: Users
        /// </summary>
        public async Task<RingCentral.MessageStoreReport> Post(
            RingCentral.CreateMessageStoreReportRequest createMessageStoreReportRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.MessageStoreReport>(this.Path(false), createMessageStoreReportRequest,
                null, restRequestConfig);
        }

        /// <summary>
        /// Returns the current status of a task on report creation.
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/message-store-report/{taskId}
        /// Rate Limit Group: Heavy
        /// App Permission: ReadMessages
        /// User Permission: Users
        /// </summary>
        public async Task<RingCentral.MessageStoreReport> Get(RestRequestConfig restRequestConfig = null)
        {
            if (this.taskId == null)
            {
                throw new System.ArgumentNullException("taskId");
            }

            return await rc.Get<RingCentral.MessageStoreReport>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public Restapi.Account.MessageStoreReport.Index MessageStoreReport(string taskId = null)
        {
            return new Restapi.Account.MessageStoreReport.Index(this, taskId);
        }
    }
}