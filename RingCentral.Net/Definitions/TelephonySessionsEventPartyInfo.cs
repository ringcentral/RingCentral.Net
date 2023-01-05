namespace RingCentral
{
    public class TelephonySessionsEventPartyInfo
    {
        /// <summary>
        /// </summary>
        public string accountId { get; set; }

        /// <summary>
        /// </summary>
        public string extensionId { get; set; }

        /// <summary>
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Enum: Inbound, Outbound
        /// </summary>
        public string direction { get; set; }

        /// <summary>
        /// </summary>
        public CallPartyInfo to { get; set; }

        /// <summary>
        /// </summary>
        public CallPartyInfo from { get; set; }

        /// <summary>
        /// </summary>
        public CallSessionStatusInfo status { get; set; }
    }
}