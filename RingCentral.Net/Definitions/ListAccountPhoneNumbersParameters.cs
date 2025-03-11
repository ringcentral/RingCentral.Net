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
        ///     ForwardedCompanyNumber, ContactCenterNumber, ConferencingNumber, MeetingsNumber, NumberPool, NumberStorage,
        ///     BusinessMobileNumber, PartnerBusinessMobileNumber, IntegrationNumber
        /// </summary>
        public string[] usageType { get; set; }

        /// <summary>
        ///     Payment type. 'External' is returned for forwarded numbers
        ///     which are not terminated in the RingCentral phone system
        ///     Enum: External, TollFree, Local, BusinessMobileNumberProvider, ExternalNumberProvider,
        ///     ExternalNumberProviderTollFree
        /// </summary>
        public string paymentType { get; set; }

        /// <summary>
        ///     Status of a phone number. If the value is `Normal`, the phone
        ///     number is ready to be used. Otherwise, it is an external number not yet
        ///     ported to RingCentral
        ///     Enum: Normal, Pending, PortedIn, Temporary, Unknown
        /// </summary>
        public string status { get; set; }
    }
}