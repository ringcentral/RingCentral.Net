namespace RingCentral
{
    /// <summary>
    ///     Please note that legacy 'Department' extension type corresponds to
    ///     'Call Queue' extensions in modern RingCentral product terminology
    /// </summary>
    public class DepartmentInfo
    {
        /// <summary>
        ///     Internal identifier of a department extension
        ///     Format: uri
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Canonical URI of an extension resource
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Number of a department extension
        /// </summary>
        public string extensionNumber { get; set; }
    }
}