using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.Extension.CallLog
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Extension.Index parent;
        public string callRecordId;
        public Index(Restapi.Account.Extension.Index parent, string callRecordId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.callRecordId = callRecordId;
        }
        public string Path(bool withParameter = true)
        {
            if (withParameter && callRecordId != null)
            {
                return $"{parent.Path()}/call-log/{callRecordId}";
            }
            return $"{parent.Path()}/call-log";
        }
        /// <summary>
        /// Returns call log records filtered by parameters specified.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/call-log
        /// Rate Limit Group: Heavy
        /// App Permission: ReadCallLog
        /// User Permission: ReadCallLog
        /// </summary>
        public async Task<RingCentral.CallLogResponse> List(RingCentral.ReadUserCallLogParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.CallLogResponse>(this.Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        /// Deletes filtered call log records.
        /// HTTP Method: delete
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/call-log
        /// Rate Limit Group: Heavy
        /// App Permission: EditCallLog
        /// User Permission: EditCallLog
        /// </summary>
        public async Task<string> Delete(RingCentral.DeleteUserCallLogParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Delete<string>(this.Path(false), null, queryParams, restRequestConfig);
        }

        /// <summary>
        /// Returns the user's individual call log record(s) by ID(s).
        /// [Bulk syntax](https://developers.ringcentral.com/guide/basics/batch-requests) is supported:
        /// multiple IDs can be specified as a comma-separated list in `{callRecordId}` (up to 50 IDs).
        /// A single ID returns HTTP 200 with `application/json`. Multiple IDs return HTTP 207 with
        /// `multipart/mixed` (one status part, then one part per record).
        /// 
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/call-log/{callRecordId}
        /// Rate Limit Group: Heavy
        /// App Permission: ReadCallLog
        /// User Permission: ReadCallLog
        /// </summary>
        public async Task<RingCentral.CallLogRecord> Get(RingCentral.ReadUserCallRecordParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            if (callRecordId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(callRecordId));
            }
            return await rc.Get<RingCentral.CallLogRecord>(this.Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.CallLog.Index CallLog(string callRecordId = null)
        {
            return new Restapi.Account.Extension.CallLog.Index(this, callRecordId);
        }
    }
}