namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation getExtensionEmergencyLocations
    /// </summary>
    public class GetExtensionEmergencyLocationsParameters
    {
        /// <summary>
        ///     Internal identifier of a site for filtering. To indicate company main
        ///     site `main-site` value should be specified. Supported only if multi-site feature
        ///     is enabled for the account. Multiple values are supported.
        /// </summary>
        public string[] siteId { get; set; }

        /// <summary>
        ///     Filters entries by the specified substring (search by chassis
        ///     ID, switch name or address) The characters range is 0-64 (if
        ///     empty the filter is ignored)
        /// </summary>
        public string searchString { get; set; }

        /// <summary>
        ///     Domestic country ID to filter results by
        /// </summary>
        public string domesticCountryId { get; set; }

        /// <summary>
        ///     Comma-separated list of fields to order results prefixed by '+'
        ///     sign (ascending order) or '-' sign (descending order). The default
        ///     sorting is by `name`
        ///     Default: +visibility
        ///     Enum: +name, +siteName, +address, +addressStatus, +usageStatus, +visibility, -name, -siteName, -address,
        ///     -addressStatus, -usageStatus, -visibility
        /// </summary>
        public string orderBy { get; set; }

        /// <summary>
        ///     Indicates a page size (number of items). The values supported:
        ///     `Max` or numeric value. If not specified, 100 records are returned
        ///     per one page
        ///     Format: int32
        /// </summary>
        public long? perPage { get; set; }

        /// <summary>
        ///     Indicates a page number to retrieve. Only positive
        ///     number values are supported
        ///     Format: int32
        ///     Default: 1
        /// </summary>
        public long? page { get; set; }

        /// <summary>
        ///     Visibility of emergency location to filter results by
        ///     Default: Public
        ///     Enum: Public
        /// </summary>
        public string visibility { get; set; }
    }
}