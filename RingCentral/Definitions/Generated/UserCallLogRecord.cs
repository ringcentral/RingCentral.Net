namespace RingCentral
{
    public class UserCallLogRecord
    {
        // Internal identifier of a cal log record
        public string id;

        // Canonical URI of a call log record
        public string uri;

        // Internal identifier of a call session
        public string sessionId;

        public CallLogCallerInfo from;

        public CallLogCallerInfo to;

        // Call type = ['Voice', 'Fax']
        // Enum: Voice, Fax
        public string type;

        // Call direction
        // Enum: Inbound, Outbound
        public string direction;

        // The call start datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
        public string startTime;

        // Call duration in seconds
        public long? duration;

        public CallLogRecordingInfo recording;
    }
}