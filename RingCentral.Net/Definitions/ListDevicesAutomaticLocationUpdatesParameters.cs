namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation listDevicesAutomaticLocationUpdates
    /// </summary>
    public class ListDevicesAutomaticLocationUpdatesParameters
    {
        /// <summary>
        ///     Internal identifier of a site. To filter devices of Main Site (Company) `main-site` must be specified. Supported
        ///     only If Multi-Site feature is enabled for the account
        /// </summary>
        public string siteId { get; set; }

        /// <summary>
        ///     Filters entries by their status of Automatic Location Updates feature
        /// </summary>
        public bool? featureEnabled { get; set; }

        /// <summary>
        ///     Internal identifier of a device model for filtering. Multiple values are supported
        /// </summary>
        public string model { get; set; }

        /// <summary>
        ///     Filters devices which support HELD protocol
        /// </summary>
        public bool? compatibleOnly { get; set; }

        /// <summary>
        ///     Filters entries which have device name or model name containing the mentioned substring. The value should be split
        ///     by spaces; the range is 0 - 64 characters, not case-sensitive. If empty the filter is ignored
        /// </summary>
        public string searchString { get; set; }

        /// <summary>
        ///     Comma-separated list of fields to order results prefixed by plus sign '+' (ascending order) or minus sign '-'
        ///     (descending order). Supported values: 'name', 'modelName', 'siteName', 'featureEnabled'
        ///     Default: name
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