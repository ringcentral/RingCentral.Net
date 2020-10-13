using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Account.CallRecording.BulkAssign
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.CallRecording.Index parent;

        public Index(Restapi.Account.CallRecording.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/bulk-assign";
        }

        /// <summary>
        /// Operation: Update Call Recording Extension List
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/account/{accountId}/call-recording/bulk-assign
        /// Rate Limit Group: Medium
        /// App Permission: ReadAccounts
        /// User Permission: ReadCompanyInfo
        /// </summary>
        public async Task<string> Post(RingCentral.BulkAccountCallRecordingsResource bulkAccountCallRecordingsResource,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<string>(this.Path(), bulkAccountCallRecordingsResource, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.CallRecording
{
    public partial class Index
    {
        public Restapi.Account.CallRecording.BulkAssign.Index BulkAssign()
        {
            return new Restapi.Account.CallRecording.BulkAssign.Index(this);
        }
    }
}