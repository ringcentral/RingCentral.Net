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

        /// <summary>
        ///     Specifies if auto-answer SIP header should be sent. If auto-answer is set to 'True', the call is automatically
        ///     answered by the supervising party, if set to 'False' - then the supervising party has to accept or decline the
        ///     monitored call
        ///     Default: true
        /// </summary>
        public bool? autoAnswer { get; set; }

        /// <summary>
        ///     Specifies session description protocol (SDP) setting. The possible values are 'sendOnly' (only sending) meaning
        ///     one-way audio streaming; and 'sendRecv' (sending/receiving) meaning two-way audio streaming
        ///     Enum: sendOnly, sendRecv
        /// </summary>
        public string mediaSDP { get; set; }
    }
}