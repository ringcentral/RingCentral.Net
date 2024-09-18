namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation readDirectoryEntry
    /// </summary>
    public class ReadDirectoryEntryParameters
    {
        /// <summary>
        ///     Flag to enable cross-site limitation checking
        ///     Example: true
        /// </summary>
        public bool? accessibleSitesOnly { get; set; }
    }
}