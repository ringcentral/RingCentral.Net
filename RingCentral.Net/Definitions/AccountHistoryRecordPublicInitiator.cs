namespace RingCentral
{
    /// <summary>
    ///     Event initiator info
    /// </summary>
    public class AccountHistoryRecordPublicInitiator
    {
        /// <summary>
        ///     Current user extension identifier
        ///     Example: 402539300008
        /// </summary>
        public string extensionId { get; set; }

        /// <summary>
        ///     Current user extension (short) number
        ///     Example: 101
        /// </summary>
        public string extensionNumber { get; set; }

        /// <summary>
        ///     Current user full name
        ///     Example: Alice Smith
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Current user role
        ///     Example: Super Admin
        /// </summary>
        public string role { get; set; }
    }
}