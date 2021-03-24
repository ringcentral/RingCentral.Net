namespace RingCentral
{
    // Query parameters for operation readGlipEvents
    public class ReadGlipEventsParameters
    {
        /// <summary>
        /// Number of groups to be fetched by one request. The maximum value is 250, by default - 30.
        /// Maximum: 250
        /// Default: 30
        /// </summary>
        public long? recordCount { get; set; }

        /// <summary>
        /// Token of a page to be returned
        /// </summary>
        public string pageToken { get; set; }
    }
}