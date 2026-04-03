namespace RingCentral
{
    public class AccountHistoryPublicRecord
    {
        /// <summary>
        ///     Internal record identifier
        ///     Example: 9835bead-397b-4ba8-b457-73f07ab79997
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Timestamp of an event (provided by a client), RFC3339 date-time format, UTC time zone.
        ///     Format: date-time
        /// </summary>
        public string eventTime { get; set; }

        /// <summary>
        /// </summary>
        public AccountHistoryRecordPublicInitiator initiator { get; set; }

        /// <summary>
        ///     Action type
        ///     Example: CHANGE_SECRET_INFO
        /// </summary>
        public string actionId { get; set; }

        /// <summary>
        ///     Operation: "CREATE", "UPDATE", "DELETE" or custom
        ///     Example: UPDATE
        /// </summary>
        public string eventType { get; set; }

        /// <summary>
        ///     Account identifier which is related with the particular record.
        ///     Example: 403858014008
        /// </summary>
        public string accountId { get; set; }

        /// <summary>
        ///     Account (company) name
        ///     Example: Some Company
        /// </summary>
        public string accountName { get; set; }

        /// <summary>
        /// </summary>
        public AccountHistoryRecordTarget target { get; set; }

        /// <summary>
        ///     IP-address of a client.
        ///     Example: 192.168.42.6
        /// </summary>
        public string clientIp { get; set; }

        /// <summary>
        ///     Custom top-level comment
        /// </summary>
        public string comment { get; set; }

        /// <summary>
        /// </summary>
        public AccountHistoryRecordPublicDetails details { get; set; }
    }
}