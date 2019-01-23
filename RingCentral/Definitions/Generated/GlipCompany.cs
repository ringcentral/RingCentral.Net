namespace RingCentral
{
    public class GlipCompany : Serializable
    {
        // Internal identifier of an RC account/Glip company, or tilde (~) to indicate a company the current user belongs to
        public string id; // Required

        // Name of a company
        public string name;

        // Domain name of a company
        public string domain;

        // Datetime of creation in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format
        public string creationTime; // Required

        // Datetime of last modification in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format
        public string lastModifiedTime; // Required
    }
}