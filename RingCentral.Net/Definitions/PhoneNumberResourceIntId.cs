namespace RingCentral
{
    public class PhoneNumberResourceIntId
    {
        /* Internal identifier of a phone number */
        public long? id;

        /* Brief information on a phone number country */
        public CountryResource country;

        /* Information on an extension to which the phone number is assigned */
        public PhoneNumberExtensionInfo extension;

        /* Custom user name of a phone number, if any */
        public string label;

        /* Location (City, State). Filled for local US numbers */
        public string location;

        /* Payment type. 'External' is returned for forwarded numbers which are not terminated in the RingCentral phone system = ['External', 'TollFree', 'Local'], */
        // Enum: External, TollFree, Local
        public string paymentType;

        /* Phone number */
        public string phoneNumber;

        /* Status of a phone number. If the value is 'Normal', the phone number is ready to be used. Otherwise it is an external number not yet ported to RingCentral , */
        public string status;

        // Enum: CompanyNumber, MainCompanyNumber, AdditionalCompanyNumber, DirectNumber, CompanyFaxNumber, ForwardedNumber, ForwardedCompanyNumber, ContactCenterNumber
        public string usageType;

        /* Type of a phone number */
        // Enum: VoiceFax, FaxOnly, VoiceOnly
        public string type;

        /* Internal identifier of a phone number reservation; encoded data including reservation type (by brand, by account, by session), particular brand/account/session data, and reservation date and time */
        public string reservationId;
    }
}