namespace RingCentral
{
    public class PromptInfo : Serializable
    {
        // Internal identifier of a prompt
        public string uri;
        // Link to a prompt metadata
        public string id;
        // Type of a prompt media content
        public string contentType;
        // Link to a prompt media content
        public string contentUri;
        // Name of a prompt
        public string filename;
    }
}