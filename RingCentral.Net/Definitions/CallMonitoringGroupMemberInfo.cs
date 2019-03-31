namespace RingCentral
{
    public class CallMonitoringGroupMemberInfo
    {
        /// <summary>
        /// Link to a call monitoring group member
        /// </summary>
        public string uri;

        /// <summary>
        /// Internal identifier of a call monitoring group member
        /// </summary>
        public string id;

        /// <summary>
        /// Extension number of a call monitoring group member
        /// </summary>
        public string extensionNumber;

        /// <summary>
        /// Call monitoring permission; mltiple values allowed: * "Monitoring" - User can monitor a group * "Monitored" - User can be monitored
        /// Enum: Monitoring, Monitored
        /// </summary>
        public string permissions;
    }
}