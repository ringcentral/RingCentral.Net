namespace RingCentral
{
    // Updates either blocked or allowed phone number list with a new phone number.
    public class AddBlockedAllowedPhoneNumber : Serializable
    {
        // A blocked/allowed phone number in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) format
        public string phoneNumber;
        // Custom name of a blocked/allowed phone number
        public string label;
        // Status of a phone number
        // Enum: Blocked, Allowed
        public string status;
    }
}