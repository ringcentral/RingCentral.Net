namespace RingCentral
{
    public class VersionInfo
    {
        /// <summary>
        /// Canonical URI of API versions
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// Version of the RingCentral REST API
        /// </summary>
        public string versionString { get; set; }

        /// <summary>
        /// Release date of this version
        /// </summary>
        public string releaseDate { get; set; }

        /// <summary>
        /// URI part determining the current version
        /// </summary>
        public string uriString { get; set; }
    }
}