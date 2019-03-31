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
        /// Http Get /restapi/v1.0/account/{accountId}/message-store-report/{taskId}/archive
        /// </summary>
        public async Task<RingCentral.MessageStoreReportArchive> List()
        {
            return await rc.Get<RingCentral.MessageStoreReportArchive>(this.Path(false));
        }

        /// <summary>
        /// Operation: Get Message Store Report Archive Content
        /// Http Get /restapi/v1.0/account/{accountId}/message-store-report/{taskId}/archive/{archiveId}
        /// </summary>
        public async Task<string> Get()
        {
            if (this.archiveId == null)
            {
                throw new System.ArgumentNullException("archiveId");
            }

            return await rc.Get<string>(this.Path());
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