namespace RingCentral
{
    public class GetVersionsResponse
    {
        /// <summary>
        /// Canonical URI of the API version
        /// </summary>
        public string uri;

        /// <summary>
        /// Full API version information: uri, number, release date
        /// </summary>
        public VersionInfo[] apiVersions;

        /// <summary>
        /// Server version
        /// </summary>
        public string serverVersion;

        /// <summary>
        /// Server revision
        /// </summary>
        public string serverRevision;
    }
}