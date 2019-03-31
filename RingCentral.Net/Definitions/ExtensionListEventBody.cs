namespace RingCentral
{
    public class ExtensionListEventBody
    {
        /// <summary>
        /// Internal identifier of an extension
        /// </summary>
        public string extensionId;

        /// <summary>
        /// Type of extension info change
        /// Enum: Create, Update, Delete
        /// </summary>
        public string eventType;

        /// <summary>
        /// Internal identifier of a subscription owner extension
        /// </summary>
        public string ownerId;
    }
}