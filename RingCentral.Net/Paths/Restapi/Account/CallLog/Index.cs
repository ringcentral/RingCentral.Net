using System.Threading.Tasks;

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

        // Operation: Get Company Call Log Records
        // Http Get /restapi/v1.0/account/{accountId}/call-log
        public async Task<RingCentral.AccountCallLogResponse> List(LoadCompanyCallLogParameters queryParams = null)
        {
            return await rc.Get<RingCentral.AccountCallLogResponse>(this.Path(false), queryParams);
        }

        // Operation: Get Company Call Log Record(s)
        // Http Get /restapi/v1.0/account/{accountId}/call-log/{callRecordId}
        public async Task<RingCentral.CompanyCallLogRecord> Get()
        {
            if (this.callRecordId == null)
            {
                throw new System.ArgumentNullException("callRecordId");
            }

            return await rc.Get<RingCentral.CompanyCallLogRecord>(this.Path());
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