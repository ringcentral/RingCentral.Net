namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation listAccountPhoneNumbersV2
    /// </summary>
    public class ListAccountPhoneNumbersV2Parameters
    {
        /// <summary>
        ///     The result set page number (1-indexed) to return
        ///     Maximum: 1000
        ///     Minimum: 1
        ///     Format: int32
        ///     Example: 1
        ///     Default: 1
        /// </summary>
        public long? page { get; set; }

        /// <summary>
        ///     The number of items per page. If provided value in the request
        ///     is greater than a maximum, the maximum value is applied
        ///     Maximum: 1000
        ///     Minimum: 1
        ///     Format: int32
        ///     Example: 100
        ///     Default: 100
        /// </summary>
        public long? perPage { get; set; }

        /// <summary>
        ///     Types of phone numbers to be returned
        ///     Enum: VoiceFax, VoiceOnly, FaxOnly
        /// </summary>
        public string[] type { get; set; }

        /// <summary>
        ///     Usage type(s) of phone numbers to be returned
        ///     Enum: MainCompanyNumber, DirectNumber, Inventory, AdditionalCompanyNumber, CompanyNumber, PhoneLine,
        ///     CompanyFaxNumber, ForwardedNumber, ForwardedCompanyNumber, ContactCenterNumber, ConferencingNumber, MeetingsNumber,
        ///     BusinessMobileNumber, ELIN
        /// </summary>
        public string[] usageType { get; set; }

        /// <summary>
        ///     Status(es) of phone numbers to be returned
        ///     Enum: Normal, Pending, PortedIn, Temporary, Unknown
        /// </summary>
        public string[] status { get; set; }

        /// <summary>
        ///     Indicates if a number is toll or toll-free
        ///     Example: Toll
        ///     Enum: Toll, TollFree
        /// </summary>
        public string tollType { get; set; }

        /// <summary>
        ///     Extension status
        ///     Enum: Enabled, Disabled, Frozen, NotActivated, Unassigned
        /// </summary>
        public string extensionStatus { get; set; }

        /// <summary>
        ///     Phone number in e.164 format to be searched for.
        ///     Parameter value can include wildcards (e.g. ''+165012345**'')
        ///     or be an exact number ''+16501234500'' - single number is searched in that case.
        ///     Make sure you escape the ''+'' in the URL as ''%2B'''
        /// </summary>
        public string phoneNumber { get; set; }
    }
}