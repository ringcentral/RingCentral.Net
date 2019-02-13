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

        public class ListQueryParams
        {
            // Extension number of a user. If specified, returns call log for a particular extension only
            public string extensionNumber;

            // Phone number of a caller/call recipient. If specified, returns all calls (both incoming and outcoming) with the phone number specified. Cannot be specified together with the extensionNumber filter
            public string phoneNumber;

            // The direction for the result records. If not specified, both inbound and outbound records are returned. Multiple values are accepted
            public string direction;

            // Call type of a record. If not specified, all call types are returned. Multiple values are accepted
            public string type;

            // View of call records. The same view parameter specified for FSync will be applied for ISync, the view cannot be changed for ISync
            // Enum: Simple, Detailed
            public string view;

            // **Deprecated**. Supported for compatibility reasons only. `true` if only recorded calls are returned. The default value is `false`. If both `withRecording` and `recordingType` are specified, `withRecording` is ignored
            public string withRecording;

            // The start datetime for resulting records in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is dateTo minus 24 hours
            public string dateFrom;

            // The end datetime for resulting records in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is current time
            public string dateTo;

            // Indicates the page number to retrieve. Only positive number values are accepted
            public string page;

            // Indicates the page size (number of items)
            public string perPage;

            // Internal identifier of a session
            public string sessionId;
        }

        public async Task<RingCentral.AccountCallLogResponse> List(ListQueryParams queryParams = null)
        {
            return await rc.Get<RingCentral.AccountCallLogResponse>(this.Path(false), queryParams);
        }

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