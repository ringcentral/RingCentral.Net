using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class CallLogRecord : Serializable
    {
        // Internal identifier of a cal log record
        public string id;
        // Canonical URI of a call log record
        public string uri;
        // Internal identifier of a call session
        public string sessionId;
        // Caller information
        public CallLogCallerInfo from;
        // Callee information
        public CallLogCallerInfo to;
        // Call type
        public string type;
        // Call direction
        public string direction;
        // Action description of the call operation
        public string action;
        // Status description of the call operation
        public string result;
        // The call start datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
        public string startTime;
        // Call duration in seconds
        public long? duration;
        // Call recording data. Returned if the call is recorded, the withRecording parameter is set to 'True' in this case
        public RecordingInfo recording;
        // For 'Detailed' view only. The datetime when the call log record was modified in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
        public string lastModifiedTime;
        // For 'Detailed' view only. Call transport
        public string transport;
        // Information about extension on whose behalf a call is initiated. For Secretary call log the Boss extension info is returned
        public ActiveCallsRecordExtensionInfo extension;
        // Information on a delegate extension that actually implemented a call action. For Secretary call log the field is returned if the current extension implemented a call. For Boss call log the field contains information on a Secretary extension which actually implemented a call on behalf of the current extension
        public DelegateInfo @delegate;
        // For 'Detailed' view only. Leg description
        public CallLogRecordLegInfo[] legs;
        public CallLogRecordMessage message;
        // Returned only if this call was deleted. Value is set to 'True' in this case
        public bool? deleted;
    }
}