using Newtonsoft.Json;

namespace RingCentral
{
    public class CompanyCallLogRecord : Serializable
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
        // Call recording data. Returned if a call is recorded
        public RecordingInfo recording;
    }
}