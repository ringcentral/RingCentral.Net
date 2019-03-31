namespace RingCentral
{
    public class AccountPresenceParameters
    {
        /// <summary>
        /// Whether to return detailed telephony state
        /// </summary>
        public bool? detailedTelephonyState;

        /// <summary>
        /// Whether to return SIP data
        /// </summary>
        public bool? sipData;

        /// <summary>
        /// Page number for account presence information
        /// </summary>
        public long? page;

        /// <summary>
        /// Number for account presence information items per page
        /// </summary>
        public long? perPage;
    }
}