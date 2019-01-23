namespace RingCentral
{
    public class RecordingInfo : Serializable
    {
        // Internal identifier of the call recording
        public string id;
        // Link to the call recording metadata resource
        public string uri;
        // Indicates recording mode used
        // Enum: Automatic, OnDemand
        public string type;
        // Link to the call recording binary content
        public string contentUri;
    }
}