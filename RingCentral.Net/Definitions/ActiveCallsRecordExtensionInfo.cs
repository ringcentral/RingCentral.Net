namespace RingCentral
{
    /// <summary>
    ///     Information about extension on whose behalf a call is initiated. For Secretary call log the Boss extension info is
    ///     returned
    /// </summary>
    public class ActiveCallsRecordExtensionInfo
    {
        /// <summary>
        ///     Link to an extension on whose behalf a call is initiated
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Internal identifier of an extension on whose behalf a call is initiated
        /// </summary>
        public string id { get; set; }
    }
}