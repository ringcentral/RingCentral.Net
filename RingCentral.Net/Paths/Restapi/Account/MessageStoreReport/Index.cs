using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.MessageStoreReport
{
    public partial class Index
    {
        public Account.Index parent;
        public RestClient rc;
        public string taskId;

        public Index(Account.Index parent, string taskId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.taskId = taskId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && taskId != null) return $"{parent.Path()}/message-store-report/{taskId}";
            return $"{parent.Path()}/message-store-report";
        }

        /// <summary>
        ///     Creates a task to collect all account messages within the specified
        ///     time interval. Maximum number of simultaneous tasks per account is 2.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/message-store-report
        ///     Rate Limit Group: Heavy
        ///     App Permission: ReadMessages
        ///     User Permission: Users
        /// </summary>
        public async Task<RingCentral.MessageStoreReport> Post(
            CreateMessageStoreReportRequest createMessageStoreReportRequest, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.MessageStoreReport>(Path(false), createMessageStoreReportRequest, null,
                restRequestConfig);
        }

        /// <summary>
        ///     Returns the current status of a task on report creation.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/message-store-report/{taskId}
        ///     Rate Limit Group: Heavy
        ///     App Permission: ReadMessages
        ///     User Permission: Users
        /// </summary>
        public async Task<RingCentral.MessageStoreReport> Get(RestRequestConfig restRequestConfig = null)
        {
            if (taskId == null) throw new ArgumentException("Parameter cannot be null", nameof(taskId));
            return await rc.Get<RingCentral.MessageStoreReport>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public MessageStoreReport.Index MessageStoreReport(string taskId = null)
        {
            return new MessageStoreReport.Index(this, taskId);
        }
    }
}