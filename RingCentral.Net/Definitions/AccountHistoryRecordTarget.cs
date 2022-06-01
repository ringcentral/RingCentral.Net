namespace RingCentral
{
    /// <summary>
    ///     Action target object (company/extension)
    /// </summary>
    public class AccountHistoryRecordTarget
    {
        /// <summary>
        ///     Extension identifier of the affected entity or 0 for Company level
        ///     Example: 404611540004
        /// </summary>
        public string objectId { get; set; }

        /// <summary>
        ///     Type of the entity. Possible values include EXTENSION, ACCOUNT, COMPANY, and TEMPLATE.
        ///     Example: Extension
        ///     Enum: Extension, Account, Company, Template
        /// </summary>
        public string objectType { get; set; }

        /// <summary>
        ///     Target extension name
        ///     Example: Charlie Williams
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Target extension (short) number of the affected entity (if the objectType is EXTENSION).
        ///     Example: 103
        /// </summary>
        public string extensionNumber { get; set; }

        /// <summary>
        ///     Target extension site identifier (if any)
        ///     Example: 871836004
        /// </summary>
        public string siteId { get; set; }
    }
}