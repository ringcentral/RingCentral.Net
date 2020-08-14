namespace RingCentral
{
    public class TelephonySessionsEventPartyInfo
    {
        /// <summary>
        /// </summary>
        public string accountId;

        /// <summary>
        /// </summary>
        public string extensionId;

        /// <summary>
        /// </summary>
        public string id;

        /// <summary>
        /// Enum: Inbound, Outbound
        /// </summary>
        public string direction;

        /// <summary>
        /// </summary>
        public CallPartyInfo to;

        /// <summary>
        /// </summary>
        public CallPartyInfo from;

        /// <summary>
        /// </summary>
        public CallSessionStatusInfo status;
    }
}