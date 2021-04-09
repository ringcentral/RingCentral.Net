namespace RingCentral
{
    // Please note that legacy 'Department' extension type corresponds to 'Call Queue' extensions in modern RingCentral product terminology
    public class DepartmentInfo
    {
        /// <summary>
        ///     Internal identifier of a department extension
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Canonical URI of a department extension
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Number of a department extension
        /// </summary>
        public string extensionNumber { get; set; }
    }
}