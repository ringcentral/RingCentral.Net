namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation readUserPresenceStatus
    /// </summary>
    public class ReadUserPresenceStatusParameters
    {
        /// <summary>
        ///     Specifies whether to return a detailed telephony state or not
        /// </summary>
        public bool? detailedTelephonyState { get; set; }

        /// <summary>
        ///     Specifies whether to return SIP data or not
        /// </summary>
        public bool? sipData { get; set; }
    }
}