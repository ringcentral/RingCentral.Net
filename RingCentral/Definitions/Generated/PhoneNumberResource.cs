namespace RingCentral
{
    public class PhoneNumberResource
    {
        public string formattedPhoneNumber;
        public string phoneNumber;

        public string type;

        // Custom user name of a phone number, if any
        public string label;

        // Usage type of a phone number
        // Enum: MobileNumber, ContactNumber, DirectNumber, ForwardedNumber
        public string usageType;
    }
}