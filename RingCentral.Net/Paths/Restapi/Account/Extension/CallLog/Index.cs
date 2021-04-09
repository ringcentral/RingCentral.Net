using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.CallLog
{
    public class Index
    {
        public string callRecordId;
        public Extension.Index parent;
        public RestClient rc;

        public Index(Extension.Index parent, string callRecordId = null)
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
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/call-log
        ///     Rate Limit Group: Heavy
        ///     App Permission: ReadCallLog
        ///     User Permission: ReadCallLog
        /// </summary>
        public async Task<UserCallLogResponse> List(ReadUserCallLogParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<UserCallLogResponse>(Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Deletes filtered call log records.
        ///     HTTP Method: delete
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/call-log
        ///     Rate Limit Group: Heavy
        ///     App Permission: EditCallLog
        ///     User Permission: EditCallLog
        /// </summary>
        public async Task<string> Delete(DeleteUserCallLogParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Delete<string>(Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Returns call log records by ID.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/call-log/{callRecordId}
        ///     Rate Limit Group: Heavy
        ///     App Permission: ReadCallLog
        ///     User Permission: ReadCallLog
        /// </summary>
        public async Task<UserCallLogRecord> Get(ReadUserCallRecordParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<UserCallLogRecord>(Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public CallLog.Index CallLog(string callRecordId = null)
        {
            return new CallLog.Index(this, callRecordId);
        }
    }
}