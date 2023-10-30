using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.CallRecordings
{
    public class Index
    {
        public Account.Index parent;
        public RestClient rc;

        public Index(Account.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/call-recordings";
        }

        /// <summary>
        ///     Deletes company call recordings by ID(s).
        ///     HTTP Method: delete
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/call-recordings
        ///     Rate Limit Group: Heavy
        ///     App Permission: EditCallLog
        ///     User Permission: EditCompanyCallRecordings
        /// </summary>
        public async Task<string> Delete(CallRecordingIds callRecordingIds, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Delete<string>(Path(), callRecordingIds, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public CallRecordings.Index CallRecordings()
        {
            return new CallRecordings.Index(this);
        }
    }
}