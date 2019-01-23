namespace RingCentral
{
    public class CallerIdPhoneInfo : Serializable
    {
        // Internal identifier of a phone number
        public string id;

        // Link to a phone number resource
        public string uri;

        // Phone number in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) (with '+' sign) format
        public string phoneNumber;
    }
}