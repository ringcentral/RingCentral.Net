namespace RingCentral
{
    public class PartySuperviseRequest
    {
        /// <summary>
        ///     Supervising mode
        ///     Required
        ///     Example: Listen
        ///     Enum: Listen
        /// </summary>
        public string mode { get; set; }

        /// <summary>
        ///     Internal identifier of a supervisor's device
        ///     Required
        ///     Example: 191888004
        /// </summary>
        public string supervisorDeviceId { get; set; }

        /// <summary>
        ///     Mailbox ID of a user that will be monitored
        ///     Required
        ///     Example: 400378008008
        /// </summary>
        public string agentExtensionId { get; set; }
    }
}