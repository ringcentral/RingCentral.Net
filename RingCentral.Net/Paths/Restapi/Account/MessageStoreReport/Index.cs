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
        /// Operation: Create Message Store Report
        /// Http Post /restapi/v1.0/account/{accountId}/message-store-report
        /// </summary>
        public async Task<RingCentral.MessageStoreReport> Post(
            RingCentral.CreateMessageStoreReportRequest createMessageStoreReportRequest)
        {
            return await rc.Post<RingCentral.MessageStoreReport>(this.Path(false), createMessageStoreReportRequest);
        }

        /// <summary>
        /// Operation: Get Message Store Report Task
        /// Http Get /restapi/v1.0/account/{accountId}/message-store-report/{taskId}
        /// </summary>
        public async Task<RingCentral.MessageStoreReport> Get()
        {
            if (this.taskId == null)
            {
                throw new System.ArgumentNullException("taskId");
            }

            return await rc.Get<RingCentral.MessageStoreReport>(this.Path());
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