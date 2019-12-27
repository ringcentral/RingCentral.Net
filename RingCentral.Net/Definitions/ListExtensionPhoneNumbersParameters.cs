namespace RingCentral
{
    public class ListExtensionPhoneNumbersParameters
    {
        /// <summary>
        /// Status of a phone number. Multiple values are supported
        /// Enum: Normal, Pending, PortedIn, Temporary
        /// </summary>
        public string status;

        /// <summary>
        /// Usage type of a phone number
        /// </summary>
        public string[] usageType;

        /// <summary>
        /// Indicates the page number to retrieve. Only positive number values are allowed. Default value is '1'
        /// </summary>
        public long? page;

        /// <summary>
        /// Indicates the page size (number of items). If not specified, the value is '100' by default
        /// </summary>
        public long? perPage;
    }
}