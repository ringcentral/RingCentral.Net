namespace RingCentral
{
    // Please note that legacy 'Department' extension type corresponds to 'Call Queue' extensions in modern RingCentral product terminology
    public class DeviceDepartmentResource
    {
        /// <summary>
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// </summary>
        public string extensionNumber { get; set; }
    }
}