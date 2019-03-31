namespace RingCentral
{
    public class GetVersionResponse
    {
        /// <summary>
        /// Canonical URI of the version info resource
        /// </summary>
        public string uri;

        /// <summary>
        /// Version of the RingCentral REST API
        /// </summary>
        public string versionString;

        /// <summary>
        /// Release date of this version
        /// </summary>
        public string releaseDate;

        /// <summary>
        /// URI part determining the current version
        /// </summary>
        public string uriString;
    }
}