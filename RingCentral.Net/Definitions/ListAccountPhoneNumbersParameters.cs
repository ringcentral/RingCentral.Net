namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation listAccountPhoneNumbers
    /// </summary>
    public class ListAccountPhoneNumbersParameters
    {
        /// <summary>
        ///     Indicates a page number to retrieve. Only positive number values
        ///     are accepted
        ///     Format: int32
        ///     Default: 1
        /// </summary>
        public long? page { get; set; }

        /// <summary>
        ///     Indicates a page size (number of items)
        ///     Format: int32
        ///     Default: 100
        /// </summary>
        public long? perPage { get; set; }

        /// <summary>
        ///     Usage type of a phone number
        ///     Enum: MainCompanyNumber, AdditionalCompanyNumber, CompanyNumber, DirectNumber, CompanyFaxNumber, ForwardedNumber,
        ///     ForwardedCompanyNumber, ContactCenterNumber, ConferencingNumber, MeetingsNumber, BusinessMobileNumber,
        ///     PartnerBusinessMobileNumber, IntegrationNumber
        /// </summary>
        public string[] usageType { get; set; }

        /// <summary>
        ///     Status of a phone number. Multiple values are supported
        ///     Enum: Normal, Pending, PortedIn, Temporary
        /// </summary>
        public string status { get; set; }
    }
}