namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation listEmergencyLocations
    /// </summary>
    public class ListEmergencyLocationsParameters
    {
        /// <summary>
        ///     Filters entries containing the specified substring in address and name fields. The characters range is 0-64; not
        ///     case-sensitive. If empty then the filter is ignored
        /// </summary>
        public string searchString { get; set; }

        /// <summary>
        ///     Internal identifier of a site for filtering. To filter by Main Site (Company) `main-site` value should be specified
        /// </summary>
        public string siteId { get; set; }

        /// <summary>
        ///     Enum: Valid, Invalid
        /// </summary>
        public string addressStatus { get; set; }

        /// <summary>
        ///     Enum: Active, Inactive
        /// </summary>
        public string usageStatus { get; set; }

        /// <summary>
        /// </summary>
        public string domesticCountryId { get; set; }

        /// <summary>
        ///     Comma-separated list of fields to order results prefixed by plus sign '+' (ascending order) or minus sign '-'
        ///     (descending order). The default value is `+address`
        ///     Default: +address
        ///     Enum: name, siteName, address, addressStatus, usageStatus
        /// </summary>
        public string orderBy { get; set; }

        /// <summary>
        ///     Indicates the page size (number of items). The values supported: `Max` or numeric value. If not specified, 100
        ///     records are returned per one page
        /// </summary>
        public long? perPage { get; set; }

        /// <summary>
        ///     Indicates the page number to retrieve. Only positive number values are supported
        ///     Default: 1
        /// </summary>
        public long? page { get; set; }
    }
}