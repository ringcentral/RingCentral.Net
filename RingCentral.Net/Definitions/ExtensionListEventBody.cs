namespace RingCentral
{
    // Notification payload body
    public class ExtensionListEventBody
    {
        /// <summary>
        ///     Internal identifier of an extension
        /// </summary>
        public string extensionId { get; set; }

        /// <summary>
        ///     Type of extension info change
        ///     Enum: Create, Update, Delete
        /// </summary>
        public string eventType { get; set; }

        /// <summary>
        ///     Internal identifier of a subscription owner extension
        /// </summary>
        public string ownerId { get; set; }
    }
}