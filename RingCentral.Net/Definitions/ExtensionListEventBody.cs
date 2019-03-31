namespace RingCentral
{
    public class ExtensionListEventBody
    {
        /* Internal identifier of an extension */
        public string extensionId;

        /* Type of extension info change */
        // Enum: Create, Update, Delete
        public string eventType;

        /* Internal identifier of a subscription owner extension */
        public string ownerId;
    }
}