namespace RingCentral
{
    public class ListAccountPhoneNumbersParameters
    {
        /// <summary>
        /// Indicates the page number to retrieve. Only positive number values are accepted
        /// Default: 1
        /// </summary>
        public long? page { get; set; }

        /// <summary>
        /// Indicates the page size (number of items)
        /// Default: 100
        /// </summary>
        public long? perPage { get; set; }

        /// <summary>
        /// Usage type of a phone number
        /// Enum: MainCompanyNumber, AdditionalCompanyNumber, CompanyNumber, DirectNumber, CompanyFaxNumber, ForwardedNumber, ForwardedCompanyNumber, ContactCenterNumber, ConferencingNumber, MeetingsNumber, BusinessMobileNumber, ExternalMobileNumber
        /// </summary>
        public string[] usageType { get; set; }

        /// <summary>
        /// Status of a phone number. Multiple values are supported
        /// Enum: Normal, Pending, PortedIn, Temporary
        /// </summary>
        public string status { get; set; }
    }
}