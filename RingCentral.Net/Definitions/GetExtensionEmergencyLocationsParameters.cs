namespace RingCentral
{
    // Query parameters for operation getExtensionEmergencyLocations
    public class GetExtensionEmergencyLocationsParameters
    {
        /// <summary>
        ///     Internal identifier of a site. To filter Main Site (Company) main-site must be specified. Supported only If
        ///     multi-site feature is enabled for the account
        /// </summary>
        public string[] siteId { get; set; }

        /// <summary>
        ///     Filters entries by the specified substring (search by chassis ID, switch name or address) The characters range is
        ///     0-64 (if empty the filter is ignored)
        /// </summary>
        public string searchString { get; set; }

        /// <summary>
        /// </summary>
        public string domesticCountryId { get; set; }

        /// <summary>
        ///     Comma-separated list of fields to order results prefixed by plus sign '+' (ascending order) or minus sign '-'
        ///     (descending order). The default value is `+visibility`, which means public ERLs will be returned first in the list,
        ///     then - private ones
        ///     Default: +visibility
        ///     Enum: name, siteName, address, addressStatus, usageStatus, visibility
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

        /// <summary>
        ///     Specifies whether to return only private or only public (company) ERLs (Emergency Response Locations)
        ///     Enum: Private, Public
        /// </summary>
        public string visibility { get; set; }
    }
}