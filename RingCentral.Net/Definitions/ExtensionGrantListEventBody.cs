namespace RingCentral
{
    /// <summary>
    ///     Notification payload body
    /// </summary>
    public class ExtensionGrantListEventBody
    {
        /// <summary>
        ///     Internal identifier of an extension
        /// </summary>
        public string extensionId { get; set; }

        /// <summary>
        ///     Internal identifier of a subscription owner extension
        /// </summary>
        public string ownerId { get; set; }
    }
}