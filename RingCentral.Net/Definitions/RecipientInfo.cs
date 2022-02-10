namespace RingCentral
{
    /// <summary>
    ///     Recipient data
    /// </summary>
    public class RecipientInfo
    {
        /// <summary>
        ///     Link to a recipient extension resource
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Internal identifier of a recipient extension
        ///     Format: int64
        /// </summary>
        public long? id { get; set; }
    }
}