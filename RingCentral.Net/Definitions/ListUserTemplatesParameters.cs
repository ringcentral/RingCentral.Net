namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation listUserTemplates
    /// </summary>
    public class ListUserTemplatesParameters
    {
        /// <summary>
        ///     Type of template
        ///     Enum: UserSettings, CallHandling
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Indicates a page number to retrieve. Only positive number values
        ///     are allowed. Default value is '1'
        ///     Format: int32
        ///     Default: 1
        /// </summary>
        public long? page { get; set; }

        /// <summary>
        ///     Indicates a page size (number of items). If not specified, the value is '100' by default
        ///     Format: int32
        ///     Default: 100
        /// </summary>
        public long? perPage { get; set; }
    }
}