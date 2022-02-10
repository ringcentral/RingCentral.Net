namespace RingCentral
{
    /// <summary>
    ///     Internal identifier of an extension the device should be assigned to
    /// </summary>
    public class DeviceExtensionInfo
    {
        /// <summary>
        ///     Internal identifier of an extension
        ///     Format: int64
        /// </summary>
        public long? id { get; set; }

        /// <summary>
        ///     Link to an extension resource
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Number of extension
        /// </summary>
        public string extensionNumber { get; set; }
    }
}