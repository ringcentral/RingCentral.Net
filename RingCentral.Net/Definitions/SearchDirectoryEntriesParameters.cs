namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation searchDirectoryEntries
    /// </summary>
    public class SearchDirectoryEntriesParameters
    {
        /// <summary>
        ///     A list of Account IDs
        /// </summary>
        public string accountId { get; set; }

        /// <summary>
        ///     A list of department names
        /// </summary>
        public string department { get; set; }

        /// <summary>
        ///     A list of Site IDs
        /// </summary>
        public string siteId { get; set; }

        /// <summary>
        ///     Extension current state
        /// </summary>
        public string extensionStatus { get; set; }

        /// <summary>
        ///     Extension types
        /// </summary>
        public string extensionType { get; set; }
    }
}