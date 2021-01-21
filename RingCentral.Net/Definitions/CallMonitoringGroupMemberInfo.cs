namespace RingCentral
{
    public class CallMonitoringGroupMemberInfo
    {
        /// <summary>
        /// Link to a call monitoring group member
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// Internal identifier of a call monitoring group member
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Extension number of a call monitoring group member
        /// </summary>
        public string extensionNumber { get; set; }

        /// <summary>
        /// Enum: Monitoring, Monitored
        /// </summary>
        public string[] permissions { get; set; }
    }
}