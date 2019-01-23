namespace RingCentral
{
    public class CallRecordingExtensionResource : Serializable
    {
        // Internal identifier of an extension
        public string id;
        public string uri;
        public string extensionNumber;
        public string type;
        // Direction of call
        // Enum: Outbound, Inbound, All
        public string callDirection;
    }
}