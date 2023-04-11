namespace RingCentral
{
    /// <summary>
    ///     Information about extension on whose behalf a call is initiated. For Secretary call log the Boss extension info is
    ///     returned
    /// </summary>
    public class ExtensionInfoCallLog
    {
        /// <summary>
        ///     Internal identifier of an extension
        ///     Required
        ///     Format: int64
        /// </summary>
        public long? id { get; set; }

        /// <summary>
        ///     Canonical URI of an extension
        ///     Required
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }
    }
}