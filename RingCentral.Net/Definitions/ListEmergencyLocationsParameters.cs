namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation listEmergencyLocations
    /// </summary>
    public class ListEmergencyLocationsParameters
    {
        /// <summary>
        ///     Internal identifier of a site for filtering. To indicate company main
        ///     site `main-site` value should be specified. Supported only if multi-site feature
        ///     is enabled for the account. Multiple values are supported.
        /// </summary>
        public string[] siteId { get; set; }

        /// <summary>
        ///     Filters entries containing the specified substring in 'address'
        ///     and 'name' fields. The character range is 0-64; not case-sensitive.
        ///     If empty then the filter is ignored
        /// </summary>
        public string searchString { get; set; }

        /// <summary>
        ///     Emergency address status
        ///     Enum: Valid, Invalid, Provisioning
        /// </summary>
        public string addressStatus { get; set; }

        /// <summary>
        ///     Status of emergency location to filter results by
        ///     Enum: Active, Inactive
        /// </summary>
        public string usageStatus { get; set; }

        /// <summary>
        ///     Domestic country ID to filter results by
        /// </summary>
        public string domesticCountryId { get; set; }

        /// <summary>
        ///     Comma-separated list of fields to order results, prefixed by
        ///     plus sign '+' (ascending order) or minus sign '-' (descending order)
        ///     Default: +address
        ///     Enum: +name, +siteName, +address, +addressStatus, +usageStatus, -name, -siteName, -address, -addressStatus,
        ///     -usageStatus
        /// </summary>
        public string orderBy { get; set; }

        /// <summary>
        ///     Indicates a page size (number of items). The values
        ///     supported: `Max` or numeric value. If not specified,
        ///     100 records are returned per one page
        ///     Format: int32
        ///     Default: 100
        /// </summary>
        public long? perPage { get; set; }

        /// <summary>
        ///     Indicates the page number to retrieve. Only positive number values
        ///     are supported
        ///     Format: int32
        ///     Default: 1
        /// </summary>
        public long? page { get; set; }
    }
}