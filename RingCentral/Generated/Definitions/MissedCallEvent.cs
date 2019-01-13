using Newtonsoft.Json;

namespace RingCentral
{
    public class MissedCallEvent : Serializable
    {
        // Universally unique identifier of a notification
        public string uuid;
        // APNS service info
        public APNSInfo pn_apns;
        // Event filter URI
        public string @event;
        // Internal identifier of a subscription
        public string subscriptionId;
        // The datetime of a call action in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format including timezone, for example 2016-03-10T18:07:52.534Z
        public string timestamp;
        // Internal identifier of an extension
        public string extensionId;
        // Calling action, for example 'StartRing'
        public string action;
        // Identifier of a call session
        public string sessionId;
        // Identifier of a server
        public string serverId;
        // Phone number of a caller. For GCM transport type '_from' property should be used
        public string from;
        // Caller name
        public string fromName;
        // Phone number of a callee
        public string to;
        // Callee name
        public string toName;
        // Unique identifier of a session
        public string sid;
        // SIP proxy registration name
        public string toUrl;
        // User data
        public string srvLvl;
        // User data
        public string srvLvlExt;
        // File containing recorded caller name
        public string recUrl;
        // Notification lifetime value in seconds, the default value is 30 seconds
        public long? pn_ttl;
        // Internal identifier of a subscription owner extension
        public string ownerId;
    }
}