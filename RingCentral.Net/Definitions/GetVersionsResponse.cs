namespace RingCentral
{
    public class GetVersionsResponse
    {
        /// <summary>
        /// Canonical URI of the API version
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// Full API version information: uri, number, release date
        /// </summary>
        public VersionInfo[] apiVersions { get; set; }

        /// <summary>
        /// Server version
        /// </summary>
        public string serverVersion { get; set; }

        /// <summary>
        /// Server revision
        /// </summary>
        public string serverRevision { get; set; }
    }
}