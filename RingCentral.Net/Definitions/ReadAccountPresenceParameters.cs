namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation readAccountPresence
    /// </summary>
    public class ReadAccountPresenceParameters
    {
        /// <summary>
        ///     Whether to return detailed telephony state
        /// </summary>
        public bool? detailedTelephonyState { get; set; }

        /// <summary>
        ///     Whether to return SIP data
        /// </summary>
        public bool? sipData { get; set; }

        /// <summary>
        ///     Page number for account presence information
        ///     Format: int32
        /// </summary>
        public long? page { get; set; }

        /// <summary>
        ///     Number for account presence information items per page
        ///     Format: int32
        /// </summary>
        public long? perPage { get; set; }
    }
}