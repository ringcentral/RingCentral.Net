using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.CallLog
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Index parent;
        public string callRecordId;

        public Index(Restapi.Account.Index parent, string callRecordId = null)
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
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/call-log
        /// Rate Limit Group: Heavy
        /// App Permission: ReadCallLog
        /// User Permission: FullCompanyCallLog
        /// </summary>
        public async Task<RingCentral.AccountCallLogResponse> List(
            RingCentral.ReadCompanyCallLogParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.AccountCallLogResponse>(this.Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        /// Returns individual call log record(s) by ID(s). Batch request is supported.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/call-log/{callRecordId}
        /// Rate Limit Group: Heavy
        /// App Permission: ReadCallLog
        /// User Permission: FullCompanyCallLog
        /// </summary>
        public async Task<RingCentral.CompanyCallLogRecord> Get(
            RingCentral.ReadCompanyCallRecordParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.CompanyCallLogRecord>(this.Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public Restapi.Account.CallLog.Index CallLog(string callRecordId = null)
        {
            return new Restapi.Account.CallLog.Index(this, callRecordId);
        }
    }
}