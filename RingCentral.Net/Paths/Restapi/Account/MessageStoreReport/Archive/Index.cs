using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.MessageStoreReport.Archive
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.MessageStoreReport.Index parent;
        public string archiveId;

        public Index(Restapi.Account.MessageStoreReport.Index parent, string archiveId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.archiveId = archiveId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && archiveId != null)
            {
                return $"{parent.Path()}/archive/{archiveId}";
            }

            return $"{parent.Path()}/archive";
        }

        /// <summary>
        /// Returns the created report with message data not including attachments.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/message-store-report/{taskId}/archive
        /// Rate Limit Group: Heavy
        /// App Permission: ReadMessages
        /// User Permission: Users
        /// </summary>
        public async Task<RingCentral.MessageStoreReportArchive> List(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.MessageStoreReportArchive>(this.Path(false), null, restRequestConfig);
        }

        /// <summary>
        /// Returns one of the report archives with message contents in application/zip format.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/message-store-report/{taskId}/archive/{archiveId}
        /// Rate Limit Group: Heavy
        /// App Permission: ReadMessages
        /// User Permission: Users
        /// </summary>
        public async Task<byte[]> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<byte[]>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.MessageStoreReport
{
    public partial class Index
    {
        public Restapi.Account.MessageStoreReport.Archive.Index Archive(string archiveId = null)
        {
            return new Restapi.Account.MessageStoreReport.Archive.Index(this, archiveId);
        }
    }
}