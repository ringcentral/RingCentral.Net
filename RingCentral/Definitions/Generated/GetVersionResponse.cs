namespace RingCentral
{
    public class GetVersionResponse : Serializable
    {
        // Canonical URI of the version info resource
        public string uri;
        // Version of the RingCentral REST API
        public string versionString;
        // Release date of this version
        public string releaseDate;
        // URI part determining the current version
        public string uriString;
    }
}