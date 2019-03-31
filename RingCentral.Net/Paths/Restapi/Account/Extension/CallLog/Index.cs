using System.Threading.Tasks;

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

        // Operation: Get User Call Log Records
        // Http Get /restapi/v1.0/account/{accountId}/extension/{extensionId}/call-log
        public async Task<RingCentral.UserCallLogResponse> List(LoadUserCallLogParameters queryParams = null)
        {
            return await rc.Get<RingCentral.UserCallLogResponse>(this.Path(false), queryParams);
        }

        // Operation: Delete User Call Log Records
        // Http Delete /restapi/v1.0/account/{accountId}/extension/{extensionId}/call-log
        public async Task<string> Delete(DeleteUserCallLogParameters queryParams = null)
        {
            return await rc.Delete<string>(this.Path(false), queryParams);
        }

        // Operation: Get User Call Record(s)
        // Http Get /restapi/v1.0/account/{accountId}/extension/{extensionId}/call-log/{callRecordId}
        public async Task<RingCentral.UserCallLogRecord> Get(GetUserCallRecordParameters queryParams = null)
        {
            if (this.callRecordId == null)
            {
                throw new System.ArgumentNullException("callRecordId");
            }

            return await rc.Get<RingCentral.UserCallLogRecord>(this.Path(), queryParams);
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