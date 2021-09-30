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
        ///     Extension identifier of the user that will be monitored
        ///     Example: 400378008008
        /// </summary>
        public string agentExtensionId { get; set; }

        /// <summary>
        ///     Specifies if auto-answer SIP header should be sent. If auto-answer is set to 'True', the call is automatically
        ///     answered by the supervising party, if set to 'False' - then the supervising party has to accept or decline the
        ///     monitored call
        ///     Default: true
        /// </summary>
        public bool? autoAnswer { get; set; }
    }
}