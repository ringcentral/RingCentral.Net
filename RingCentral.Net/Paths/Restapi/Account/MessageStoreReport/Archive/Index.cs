using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.MessageStoreReport.Archive
{
    public class Index
    {
        public string archiveId;
        public MessageStoreReport.Index parent;
        public RestClient rc;

        public Index(MessageStoreReport.Index parent, string archiveId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.archiveId = archiveId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && archiveId != null) return $"{parent.Path()}/archive/{archiveId}";
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
        public async Task<MessageStoreReportArchive> List(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<MessageStoreReportArchive>(Path(false), null, restRequestConfig);
        }

        /// <summary>
        ///     Returns one of the report archives with message contents in application/zip format.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/message-store-report/{taskId}/archive/{archiveId}
        ///     Rate Limit Group: Heavy
        ///     App Permission: ReadMessages
        ///     User Permission: Users
        /// </summary>
        public async Task<byte[]> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<byte[]>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.MessageStoreReport
{
    public partial class Index
    {
        public Archive.Index Archive(string archiveId = null)
        {
            return new Archive.Index(this, archiveId);
        }
    }
}