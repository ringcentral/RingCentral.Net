using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.MessageStoreReport.Archive
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.MessageStoreReport.Index parent;
        public Index(Restapi.Account.MessageStoreReport.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }
        public string Path(bool withParameter = false)
        {
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
        public async Task<RingCentral.MessageStoreReportArchive> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.MessageStoreReportArchive>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.MessageStoreReport
{
    public partial class Index
    {
        public Restapi.Account.MessageStoreReport.Archive.Index Archive()
        {
            return new Restapi.Account.MessageStoreReport.Archive.Index(this);
        }
    }
}