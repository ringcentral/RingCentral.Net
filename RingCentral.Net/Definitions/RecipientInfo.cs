namespace RingCentral
{
    // Recipient data
    public class RecipientInfo
    {
        /// <summary>
        ///     Link to a recipient extension resource
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Internal identifier of a recipient extension
        /// </summary>
        public long? id { get; set; }
    }
}