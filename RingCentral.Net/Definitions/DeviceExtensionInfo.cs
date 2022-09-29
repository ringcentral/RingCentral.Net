namespace RingCentral
{
    public class DeviceExtensionInfo
    {
        /// <summary>
        ///     Internal identifier of an extension
        ///     Format: int64
        /// </summary>
        public long? id { get; set; }

        /// <summary>
        ///     Canonical URL of an extension resource
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Short extension number
        /// </summary>
        public string extensionNumber { get; set; }
    }
}