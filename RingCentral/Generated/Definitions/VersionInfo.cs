using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class VersionInfo : Serializable
    {
        // Canonical URI of API versions
        public string uri;
        // Version of the RingCentral REST API
        public string versionString;
        // Release date of this version
        public string releaseDate;
        // URI part determining the current version
        public string uriString;
    }
}