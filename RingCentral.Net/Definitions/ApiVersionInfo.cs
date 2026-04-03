namespace RingCentral
{
    public class ApiVersionInfo
    {
        /// <summary>
        ///     Canonical URI of API version
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Version of the RingCentral REST API
        /// </summary>
        public string versionString { get; set; }

        /// <summary>
        ///     Release date of this version
        ///     Format: date-time
        /// </summary>
        public string releaseDate { get; set; }

        /// <summary>
        ///     URI part determining the current version
        /// </summary>
        public string uriString { get; set; }
    }
}