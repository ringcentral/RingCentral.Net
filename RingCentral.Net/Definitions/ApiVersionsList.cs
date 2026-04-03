namespace RingCentral
{
    public class ApiVersionsList
    {
        /// <summary>
        ///     Canonical URI of the API version
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Full API version information: uri, number, release date
        /// </summary>
        public ApiVersionInfo[] apiVersions { get; set; }

        /// <summary>
        ///     Server version
        /// </summary>
        public string serverVersion { get; set; }

        /// <summary>
        ///     Server revision
        /// </summary>
        public string serverRevision { get; set; }
    }
}