using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.CallRecording.BulkAssign
{
    public class Index
    {
        public CallRecording.Index parent;
        public RestClient rc;

        public Index(CallRecording.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/bulk-assign";
        }

        /// <summary>
        ///     Creates or updates the list of extensions to be recorded.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/call-recording/bulk-assign
        ///     Rate Limit Group: Medium
        ///     App Permission: ReadAccounts
        ///     User Permission: ReadCompanyInfo
        /// </summary>
        public async Task<string> Post(BulkAccountCallRecordingsResource bulkAccountCallRecordingsResource,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<string>(Path(), bulkAccountCallRecordingsResource, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.CallRecording
{
    public partial class Index
    {
        public BulkAssign.Index BulkAssign()
        {
            return new BulkAssign.Index(this);
        }
    }
}