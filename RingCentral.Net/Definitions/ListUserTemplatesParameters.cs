namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation listUserTemplates
    /// </summary>
    public class ListUserTemplatesParameters
    {
        /// <summary>
        ///     Type of a template
        ///     Enum: UserSettings, CallHandling
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Indicates the page number to retrieve. Only positive number values
        ///     are allowed
        /// </summary>
        public string page { get; set; }

        /// <summary>
        ///     Indicates the page size (number of items)
        /// </summary>
        public string perPage { get; set; }
    }
}