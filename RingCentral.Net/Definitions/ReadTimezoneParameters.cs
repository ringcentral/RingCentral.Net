namespace RingCentral
{
    // Query parameters for operation readTimezone
    public class ReadTimezoneParameters
    {
        /// <summary>
        /// Indicates the page number to retrieve. Only positive number values are accepted
        /// Default: 1
        /// </summary>
        public string page { get; set; }

        /// <summary>
        /// Indicates the page size (number of items)
        /// Default: 100
        /// </summary>
        public string perPage { get; set; }
    }
}