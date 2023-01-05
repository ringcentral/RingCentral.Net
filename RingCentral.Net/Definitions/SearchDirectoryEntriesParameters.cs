namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation searchDirectoryEntries
    /// </summary>
    public class SearchDirectoryEntriesParameters
    {
        /// <summary>
        ///     A list of Account IDs
        ///     Example: 400131426008
        /// </summary>
        public string accountId { get; set; }

        /// <summary>
        ///     A list of department names
        ///     Example: North office
        /// </summary>
        public string department { get; set; }

        /// <summary>
        ///     A list of Site IDs
        ///     Example: 872781797006
        /// </summary>
        public string siteId { get; set; }

        /// <summary>
        ///     Extension current state
        ///     Example: Enabled
        /// </summary>
        public string extensionStatus { get; set; }

        /// <summary>
        ///     Extension types
        ///     Example: User
        /// </summary>
        public string extensionType { get; set; }
    }
}