namespace RingCentral
{
    /// <summary>
    ///     Information on extension
    /// </summary>
    public class ExtensionInfoCallLog
    {
        /// <summary>
        ///     Internal identifier of an extension
        ///     Format: int64
        /// </summary>
        public long? id { get; set; }

        /// <summary>
        ///     Canonical URI of an extension
        /// </summary>
        public string uri { get; set; }
    }
}