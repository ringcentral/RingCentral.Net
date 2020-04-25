using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Account.CallLog
{
    public partial class Index
    {
        public RestClient rc;
        public string callRecordId;
        public Restapi.Account.Index parent;

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
        /// Operation: Get Company Call Log Records
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/call-log
        /// Rate Limit Group: Heavy
        /// App Permission: ReadCallLog
        /// User Permission: FullCompanyCallLog
        /// </summary>
        public async Task<RingCentral.AccountCallLogResponse> List(ReadCompanyCallLogParameters queryParams = null,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Get<RingCentral.AccountCallLogResponse>(this.Path(false), queryParams, cancellationToken);
        }

        /// <summary>
        /// Operation: Get Company Call Log Record(s)
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/call-log/{callRecordId}
        /// Rate Limit Group: Heavy
        /// App Permission: ReadCallLog
        /// User Permission: FullCompanyCallLog
        /// </summary>
        public async Task<RingCentral.CompanyCallLogRecord> Get(ReadCompanyCallRecordParameters queryParams = null,
            CancellationToken? cancellationToken = null)
        {
            if (this.callRecordId == null)
            {
                throw new System.ArgumentNullException("callRecordId");
            }

            return await rc.Get<RingCentral.CompanyCallLogRecord>(this.Path(), queryParams, cancellationToken);
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