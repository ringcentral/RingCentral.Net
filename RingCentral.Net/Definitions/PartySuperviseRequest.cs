namespace RingCentral
{
    public class PartySuperviseRequest
    {
        /// <summary>
        /// Supervising mode
        /// Required
        /// Enum: Listen
        /// </summary>
        public string mode;

        /// <summary>
        /// Internal identifier of a supervisor's device
        /// Required
        /// </summary>
        public string supervisorDeviceId;

        /// <summary>
        /// Mailbox ID of a user that will be monitored
        /// Required
        /// </summary>
        public string agentExtensionId;
    }
}