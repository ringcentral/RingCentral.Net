using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.MessageStoreReport.Archive
{
    public partial class Index
    {
        public RestClient rc;
        public string archiveId;
        public Restapi.Account.MessageStoreReport.Index parent;

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
        /// Operation: Get Message Store Report Archive
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/message-store-report/{taskId}/archive
        /// Rate Limit Group: Heavy
        /// App Permission: ReadMessages
        /// User Permission: Users
        /// </summary>
        public async Task<RingCentral.MessageStoreReportArchive> List(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.MessageStoreReportArchive>(this.Path(false), null, restRequestConfig);
        }

        /// <summary>
        /// Operation: Get Message Store Report Archive Content
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/message-store-report/{taskId}/archive/{archiveId}
        /// Rate Limit Group: Heavy
        /// App Permission: ReadMessages
        /// User Permission: Users
        /// </summary>
        public async Task<string> Get(RestRequestConfig restRequestConfig = null)
        {
            if (this.archiveId == null)
            {
                throw new System.ArgumentNullException("archiveId");
            }

            return await rc.Get<string>(this.Path(), null, restRequestConfig);
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