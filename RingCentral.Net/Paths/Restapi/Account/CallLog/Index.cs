using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.CallLog
{
    public class Index
    {
        public string callRecordId;
        public Account.Index parent;
        public RestClient rc;

        public Index(Account.Index parent, string callRecordId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.callRecordId = callRecordId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && callRecordId != null) return $"{parent.Path()}/call-log/{callRecordId}";

            return $"{parent.Path()}/call-log";
        }

        /// <summary>
        ///     Returns call log records filtered by parameters specified.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/call-log
        ///     Rate Limit Group: Heavy
        ///     App Permission: ReadCallLog
        ///     User Permission: FullCompanyCallLog
        /// </summary>
        public async Task<AccountCallLogResponse> List(
            ReadCompanyCallLogParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<AccountCallLogResponse>(Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Returns individual call log record(s) by ID(s). Batch request is supported.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/call-log/{callRecordId}
        ///     Rate Limit Group: Heavy
        ///     App Permission: ReadCallLog
        ///     User Permission: FullCompanyCallLog
        /// </summary>
        public async Task<CompanyCallLogRecord> Get(
            ReadCompanyCallRecordParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<CompanyCallLogRecord>(Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public CallLog.Index CallLog(string callRecordId = null)
        {
            return new CallLog.Index(this, callRecordId);
        }
    }
}