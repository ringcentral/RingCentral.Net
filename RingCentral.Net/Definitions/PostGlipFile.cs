namespace RingCentral
{
    public class PostGlipFile
    {
        // Internal identifier of a file
        public string id; // Required

        // Link to binary content
        public string contentUri; // Required

        // Name of a file
        public string name;
    }
}