using Newtonsoft.Json;

namespace RingCentral
{
    public class CallLogRecordLegInfo : Serializable
    {
        // Action description of the call operation
        public string action;
        // Call direction
        public string direction;
        // Call duration in seconds
        public int? duration;
        // Information on extension
        public ExtensionInfoCallLog extension;
        // Leg type
        public string legType;
        // The call start datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
        public string startTime;
        // Call type
        public string type;
        // Status description of the call operation
        public string result;
        // Caller information
        public CallLogCallerInfo from;
        // Callee information
        public CallLogCallerInfo to;
        // Call transport
        public string transport;
        // Call recording data. Returned if the call is recorded
        public RecordingInfo recording;
        public bool? master;
    }
}