namespace RingCentral
{
    public class LoadGlipEventsParameters
    {
        /// <summary>
        /// Number of groups to be fetched by one request. The maximum value is 250, by default - 30.
        /// Maximum: 250
        /// Default: 30
        /// </summary>
        public long? recordCount;

        /// <summary>
        /// Token of a page to be returned
        /// </summary>
        public string pageToken;
    }
}