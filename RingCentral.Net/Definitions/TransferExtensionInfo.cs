namespace RingCentral
{
    /// <summary>
    ///     Transfer extension settings, set/returned if `callHandlingAction` is specified as `TransferToExtension`
    /// </summary>
    public class TransferExtensionInfo
    {
        /// <summary>
        ///     Internal identifier of an extension
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Canonical URI of an extension resource
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Extension name
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Extension number
        /// </summary>
        public string extensionNumber { get; set; }
    }
}