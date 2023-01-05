namespace RingCentral
{
    public class ExtensionInfoCallLog
    {
        /// <summary>
        ///     Internal identifier of an extension
        ///     Format: int64
        /// </summary>
        public long? id { get; set; }

        /// <summary>
        ///     Canonical URI of an extension
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }
    }
}