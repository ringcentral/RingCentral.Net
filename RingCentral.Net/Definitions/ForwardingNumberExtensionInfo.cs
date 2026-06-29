namespace RingCentral
{
    /// <summary>
    /// Extension information (for ExtensionApps type only)
    /// </summary>
    public class ForwardingNumberExtensionInfo
    {
        /// <summary>
        ///     Internal identifier of an extension
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Extension name
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Number of an extension
        /// </summary>
        public string extensionNumber { get; set; }
    }
}