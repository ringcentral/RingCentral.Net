namespace RingCentral
{
    public class SuperviseCallSessionRequest
    {
        /// <summary>
        /// Supervising mode
        /// Required
        /// Enum: Listen
        /// </summary>
        public string mode;

        /// <summary>
        /// Internal identifier of a supervisor's device which will be used for call session monitoring
        /// Required
        /// </summary>
        public string supervisorDeviceId;

        /// <summary>
        /// Extension number of the user that will be monitored
        /// </summary>
        public string agentExtensionNumber;

        /// <summary>
        /// Extension identifier of the user that will be monitored
        /// </summary>
        public string agentExtensionId;
    }
}