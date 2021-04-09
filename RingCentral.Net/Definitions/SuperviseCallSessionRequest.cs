namespace RingCentral
{
    public class SuperviseCallSessionRequest
    {
        /// <summary>
        ///     Supervising mode
        ///     Required
        ///     Example: Listen
        ///     Enum: Listen
        /// </summary>
        public string mode { get; set; }

        /// <summary>
        ///     Internal identifier of a supervisor's device which will be used for call session monitoring
        ///     Required
        ///     Example: 191888004
        /// </summary>
        public string supervisorDeviceId { get; set; }

        /// <summary>
        ///     Extension number of the user that will be monitored
        ///     Example: 105
        /// </summary>
        public string agentExtensionNumber { get; set; }

        /// <summary>
        ///     Extension identifier of the user that will be monitored
        ///     Example: 400378008008
        /// </summary>
        public string agentExtensionId { get; set; }
    }
}