namespace RingCentral
{
    public class ListAccountPhoneNumbersParameters
    {
        /// <summary>
        /// Indicates the page number to retrieve. Only positive number values are accepted
        /// Default: 1
        /// </summary>
        public long? page;

        /// <summary>
        /// Indicates the page size (number of items)
        /// Default: 100
        /// </summary>
        public long? perPage;

        /// <summary>
        /// Usage type of a phone number
        /// </summary>
        public string[] usageType;

        /// <summary>
        /// Status of a phone number. Multiple values are supported
        /// Enum: Normal, Pending, PortedIn, Temporary
        /// </summary>
        public string status;
    }
}