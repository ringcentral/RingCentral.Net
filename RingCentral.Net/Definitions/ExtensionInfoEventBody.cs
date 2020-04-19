namespace RingCentral
{
    public class ExtensionInfoEventBody
    {
        /// <summary>
        /// Internal identifier of an extension
        /// </summary>
        public string extensionId;

        /// <summary>
        /// Type of extension info change
        /// Enum: Update, Delete
        /// </summary>
        public string eventType;

        /// <summary>
        /// Returned for 'Update' event type only
        /// </summary>
        public string[] hints;

        /// <summary>
        /// Internal identifier of a subscription owner extension
        /// </summary>
        public string ownerId;
    }
}