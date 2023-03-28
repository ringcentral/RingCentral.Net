namespace RingCentral
{
    /// <summary>
    ///     Extension information
    /// </summary>
    public class SiteIVRActionsExtensionInfo
    {
        /// <summary>
        ///     Internal identifier of an extension
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Canonical URI of an extension
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Name of an extension user
        /// </summary>
        public string name { get; set; }
    }
}