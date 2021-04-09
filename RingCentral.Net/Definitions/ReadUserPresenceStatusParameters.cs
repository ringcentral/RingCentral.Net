namespace RingCentral
{
    // Query parameters for operation readUserPresenceStatus
    public class ReadUserPresenceStatusParameters
    {
        /// <summary>
        ///     Whether to return detailed telephony state
        /// </summary>
        public bool? detailedTelephonyState { get; set; }

        /// <summary>
        ///     Whether to return SIP data
        /// </summary>
        public bool? sipData { get; set; }
    }
}