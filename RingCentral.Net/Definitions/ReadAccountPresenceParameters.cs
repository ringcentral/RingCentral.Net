namespace RingCentral
{
    // Query parameters for operation readAccountPresence
    public class ReadAccountPresenceParameters
    {
        /// <summary>
        /// Whether to return detailed telephony state
        /// </summary>
        public bool? detailedTelephonyState { get; set; }

        /// <summary>
        /// Whether to return SIP data
        /// </summary>
        public bool? sipData { get; set; }

        /// <summary>
        /// Page number for account presence information
        /// </summary>
        public long? page { get; set; }

        /// <summary>
        /// Number for account presence information items per page
        /// </summary>
        public long? perPage { get; set; }
    }
}