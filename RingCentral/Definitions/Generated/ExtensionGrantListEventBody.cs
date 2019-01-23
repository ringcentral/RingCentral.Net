namespace RingCentral
{
    public class ExtensionGrantListEventBody : Serializable
    {
        // Internal identifier of an extension
        public string extensionId;
        // Internal identifier of a subscription owner extension
        public string ownerId;
    }
}