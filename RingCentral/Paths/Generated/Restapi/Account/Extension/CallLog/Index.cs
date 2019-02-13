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

        public async Task<RingCentral.UserCallLogResponse> List(ListQueryParams queryParams = null)
        {
            return await rc.Get<RingCentral.UserCallLogResponse>(this.Path(false), queryParams);
        }

        public async Task<RingCentral.UserCallLogResponse> List(object queryParams)
        {
            return await rc.Get<RingCentral.UserCallLogResponse>(this.Path(false), queryParams);
        }

        public async Task<string> Delete(DeleteQueryParams queryParams = null)
        {
            return await rc.Delete<string>(this.Path(false), queryParams);
        }

        public async Task<string> Delete(object queryParams)
        {
            return await rc.Delete<string>(this.Path(false), queryParams);
        }

        public async Task<RingCentral.UserCallLogRecord> Get(GetQueryParams queryParams = null)
        {
            if (this.callRecordId == null)
            {
                throw new System.ArgumentNullException("callRecordId");
            }

            return await rc.Get<RingCentral.UserCallLogRecord>(this.Path(), queryParams);
        }

        public async Task<RingCentral.UserCallLogRecord> Get(object queryParams)
        {
            if (this.callRecordId == null)
            {
                throw new System.ArgumentNullException("callRecordId");
            }

            return await rc.Get<RingCentral.UserCallLogRecord>(this.Path(), queryParams);
        }
    }

    public class ListQueryParams
    {
        // Extension number of a user. If specified, returns call log for a particular extension only
        public string extensionNumber;

        // If 'True' then calls from/to blocked numbers are returned
        public bool? showBlocked;

        // Phone number of a caller/callee. If specified, returns all calls (both incoming and outcoming) with the phone number specified
        public string phoneNumber;

        // The direction for the resulting records. If not specified, both inbound and outbound records are returned. Multiple values are accepted
        public string[] direction;

        // Internal identifier of a session
        public string sessionId;

        // Call type of a record. It is allowed to specify more than one type. If not specified, all call types are returned. Multiple values are accepted
        public string[] type;

        // Call transport type. 'PSTN' specifies that a call leg is initiated from the PSTN network provider; 'VoIP' - from an RC phone. By default this filter is disabled
        public string[] transport;

        // View of call records. The same view parameter specified for FSync will be applied for ISync, the view cannot be changed for ISync
        // Enum: Simple, Detailed
        public string view;

        // **Deprecated**. Supported for compatibility reasons only. `true` if only recorded calls are returned. The default value is `false`. If both `withRecording` and `recordingType` are specified, `withRecording` is ignored
        public bool? withRecording;

        // The end datetime for resulting records in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is current time
        public string dateTo;

        // The start datetime for resulting records in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is dateTo minus 24 hours
        public string dateFrom;

        // Indicates the page number to retrieve. Only positive number values are allowed
        public long? page;

        // Indicates the page size (number of items)
        public long? perPage;

        // If 'True' then deleted calls are returned
        public bool? showDeleted;
    }

    public class DeleteQueryParams
    {
        // The end datetime for records deletion in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is current time
        public string dateTo;

        public string phoneNumber;

        public string extensionNumber;

        public string[] type;

        public string[] direction;

        public string dateFrom;
    }

    public class GetQueryParams
    {
        // View of call records. The same view parameter specified for FSync will be applied for ISync, the view cannot be changed for ISync
        // Enum: Simple, Detailed
        public string view;
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