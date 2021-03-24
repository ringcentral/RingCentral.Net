namespace RingCentral
{
    // Query parameters for operation listBlockedAllowedNumbers
    public class ListBlockedAllowedNumbersParameters
    {
        /// <summary>
        /// </summary>
        public long? page { get; set; }

        /// <summary>
        /// </summary>
        public long? perPage { get; set; }

        /// <summary>
        /// Enum: Blocked, Allowed
        /// </summary>
        public string status { get; set; }
    }
}