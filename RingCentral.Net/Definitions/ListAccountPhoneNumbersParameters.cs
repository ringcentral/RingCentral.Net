namespace RingCentral
{
    /// <summary>
    /// Query parameters for operation listAccountPhoneNumbers
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
        ///     Extension status
        ///     Enum: Enabled, Disabled, Frozen, NotActivated, Unassigned
        /// </summary>
        public string extensionStatus { get; set; }

        /// <summary>
        ///     Usage type of a phone number
        ///     Enum: MainCompanyNumber, AdditionalCompanyNumber, CompanyNumber, DirectNumber, CompanyFaxNumber, FmcBusinessMobileNumber, InventoryFmcBusinessMobileNumber, ForwardedNumber, ForwardedCompanyNumber, ContactCenterNumber, ConferencingNumber, MeetingsNumber, NumberPool, BusinessMobileNumber, ELIN, PartnerBusinessMobileNumber, NumberPoolPartnerBusinessMobileNumber, NumberStorage, IntegrationNumber, InventoryMobileNumber
        /// </summary>
        public string[] usageType { get; set; }

        /// <summary>
        ///     Payment type of a phone number. Multiple values are supported
        ///     Enum: External, TollFree, Local, BusinessMobileNumberProvider, ExternalNumberProvider, ExternalNumberProviderTollFree, Mobile
        /// </summary>
        public string[] paymentType { get; set; }

        /// <summary>
        ///     Status of a phone number. Multiple values are supported
        ///     Enum: Normal, Pending, PortedIn, Temporary, Unknown
        /// </summary>
        public string[] status { get; set; }
    }
}