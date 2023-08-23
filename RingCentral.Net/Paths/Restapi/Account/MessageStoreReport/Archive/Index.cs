using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.MessageStoreReport.Archive
{
    public class Index
    {
        public MessageStoreReport.Index parent;
        public RestClient rc;

        public Index(MessageStoreReport.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/archive";
        }

        /// <summary>
        ///     Returns the created report with message data not including attachments.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/message-store-report/{taskId}/archive
        ///     Rate Limit Group: Heavy
        ///     App Permission: ReadMessages
        ///     User Permission: Users
        /// </summary>
        public async Task<MessageStoreReportArchive> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<MessageStoreReportArchive>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.MessageStoreReport
{
    public partial class Index
    {
        public Archive.Index Archive()
        {
            return new Archive.Index(this);
        }
    }
}