namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation listAutomaticLocationUpdatesUsers
    /// </summary>
    public class ListAutomaticLocationUpdatesUsersParameters
    {
        /// <summary>
        ///     Extension type. Multiple values are supported
        ///     Enum: User, Limited
        /// </summary>
        public string[] type { get; set; }

        /// <summary>
        ///     Filters entries containing the specified substring in user name,
        ///     extension or department. The characters range is 0-64; not case-sensitive.
        ///     If empty then the filter is ignored
        /// </summary>
        public string searchString { get; set; }

        /// <summary>
        ///     Department name to filter the users. The value range is 0-64;
        ///     not case-sensitive. If not specified then the parameter is ignored. Multiple
        ///     values are supported
        /// </summary>
        public string[] department { get; set; }

        /// <summary>
        ///     Internal identifier of a site for filtering. To indicate company main
        ///     site `main-site` value should be specified. Supported only if multi-site feature
        ///     is enabled for the account. Multiple values are supported.
        /// </summary>
        public string[] siteId { get; set; }

        /// <summary>
        ///     Filters entries by their status of Automatic Location Updates
        ///     feature
        /// </summary>
        public bool? featureEnabled { get; set; }

        /// <summary>
        ///     Comma-separated list of fields to order results prefixed by plus sign '+' (ascending order),
        ///     or minus sign '-' (descending order).
        ///     Supported values: 'name', 'modelName', 'siteName', 'featureEnabled'.
        ///     The default sorting is by `name`
        /// </summary>
        public string[] orderBy { get; set; }

        /// <summary>
        ///     Indicates a page size (number of items). The values supported:
        ///     `Max` or numeric value. If not specified, 100 records are returned per one
        ///     page
        ///     Format: int32
        /// </summary>
        public long? perPage { get; set; }

        /// <summary>
        ///     Indicates a page number to retrieve. Only positive number values
        ///     are supported
        ///     Format: int32
        ///     Default: 1
        /// </summary>
        public long? page { get; set; }
    }
}