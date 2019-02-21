namespace RingCentral
{
    public class CallMonitoringGroupMemberInfo
    {
        // Link to a call monitoring group member
        public string uri;

        // Internal identifier of a call monitoring group member
        public string id;

        // Extension number of a call monitoring group member
        public string extensionNumber;

        // Call monitoring permission; mltiple values allowed: * "Monitoring" - User can monitor a group * "Monitored" - User can be monitored
        // Enum: Monitoring, Monitored
        public string permissions;
    }
}