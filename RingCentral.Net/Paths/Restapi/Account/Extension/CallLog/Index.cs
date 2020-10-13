using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Account.Extension.CallLog
{
    public partial class Index
    {
        public RestClient rc;
        public string callRecordId;
        public Restapi.Account.Extension.Index parent;

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
        /// Operation: Get User Call Log Records
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/call-log
        /// Rate Limit Group: Heavy
        /// App Permission: ReadCallLog
        /// User Permission: ReadCallLog
        /// </summary>
        public async Task<RingCentral.UserCallLogResponse> List(ReadUserCallLogParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.UserCallLogResponse>(this.Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        /// Operation: Delete User Call Log
        /// HTTP Method: DELETE
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/call-log
        /// Rate Limit Group: Heavy
        /// App Permission: EditCallLog
        /// User Permission: EditCallLog
        /// </summary>
        public async Task<string> Delete(DeleteUserCallLogParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Delete<string>(this.Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        /// Operation: Get User Call Record
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/call-log/{callRecordId}
        /// Rate Limit Group: Heavy
        /// App Permission: ReadCallLog
        /// User Permission: ReadCallLog
        /// </summary>
        public async Task<RingCentral.UserCallLogRecord> Get(ReadUserCallRecordParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            if (this.callRecordId == null)
            {
                throw new System.ArgumentNullException("callRecordId");
            }

            return await rc.Get<RingCentral.UserCallLogRecord>(this.Path(), queryParams, restRequestConfig);
        }

        public async Task<BatchResponse<RingCentral.UserCallLogRecord>[]> BatchGet(
            ReadUserCallRecordParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            if (!this.Path().Contains(","))
            {
                throw new System.ArgumentException(
                    "In order to make a BatchGet, please specify multiple IDs delimited by ','");
            }

            return await rc.BatchGet<RingCentral.UserCallLogRecord>(this.Path(), queryParams, restRequestConfig);
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