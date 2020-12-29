namespace RingCentral
{
    // GCM data
    public class GCMData
    {
        /// <summary>
        /// Event filter URI
        /// </summary>
        public string @event;

        /// <summary>
        /// Internal identifier of a subscription
        /// </summary>
        public string subscriptionId;

        /// <summary>
        /// The datetime of a call action in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format including timezone, for example 2016-03-10T18:07:52.534Z
        /// </summary>
        public string timestamp;

        /// <summary>
        /// Internal identifier of an extension
        /// Default: ~
        /// </summary>
        public string extensionId;

        /// <summary>
        /// Calling action, for example 'StartRing'
        /// </summary>
        public string action;

        /// <summary>
        /// Identifier of a call session
        /// </summary>
        public string sessionId;

        /// <summary>
        /// Identifier of a server
        /// </summary>
        public string serverId;

        /// <summary>
        /// Phone number of a caller
        /// </summary>
        public string _from;

        /// <summary>
        /// Caller name
        /// </summary>
        public string fromName;

        /// <summary>
        /// Phone number of a callee
        /// </summary>
        public string to;

        /// <summary>
        /// Callee name
        /// </summary>
        public string toName;

        /// <summary>
        /// Unique identifier of a session
        /// </summary>
        public string sid;

        /// <summary>
        /// SIP proxy registration name
        /// </summary>
        public string toUrl;

        /// <summary>
        /// User data
        /// </summary>
        public string srvLvl;

        /// <summary>
        /// User data
        /// </summary>
        public string srvLvlExt;
    }
}