namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation readDirectoryEntry
    /// </summary>
    public class ReadDirectoryEntryParameters
    {
        /// <summary>
        ///     Allows to make lookups across a whole directory skipping a filtering logic of Cross-Site access management feature.
        ///     Default: true
        /// </summary>
        public bool? accessibleSitesOnly { get; set; }
    }
}