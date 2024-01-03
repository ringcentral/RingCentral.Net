namespace RingCentral
{
    /// <summary>
    ///     Recipient data
    /// </summary>
    public class RecipientInfo
    {
        /// <summary>
        ///     Link to a voicemail recipient extension resource
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Internal identifier of a voicemail recipient
        /// </summary>
        public string id { get; set; }
    }
}