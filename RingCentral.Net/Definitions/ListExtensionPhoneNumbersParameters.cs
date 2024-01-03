namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation listExtensionPhoneNumbers
    /// </summary>
    public class ListExtensionPhoneNumbersParameters
    {
        /// <summary>
        ///     Status of a phone number
        ///     Enum: Normal, Pending, PortedIn, Temporary
        /// </summary>
        public string status { get; set; }

        /// <summary>
        ///     Usage type of a phone number
        ///     Enum: MainCompanyNumber, AdditionalCompanyNumber, CompanyNumber, DirectNumber, CompanyFaxNumber, ForwardedNumber,
        ///     ForwardedCompanyNumber, BusinessMobileNumber, PartnerBusinessMobileNumber, IntegrationNumber
        /// </summary>
        public string[] usageType { get; set; }

        /// <summary>
        ///     Indicates a page number to retrieve. Only positive number values
        ///     are allowed. Default value is '1'
        ///     Format: int32
        ///     Default: 1
        /// </summary>
        public long? page { get; set; }

        /// <summary>
        ///     Indicates a page size (number of items). If not specified, the value is '100' by default
        ///     Format: int32
        ///     Default: 100
        /// </summary>
        public long? perPage { get; set; }
    }
}