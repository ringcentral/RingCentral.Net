namespace RingCentral
{
    public class CallerIdPhoneInfo
    {
        /// <summary>
        /// Internal identifier of a phone number
        /// </summary>
        public string id;

        /// <summary>
        /// Link to a phone number resource
        /// </summary>
        public string uri;

        /// <summary>
        /// Phone number in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) (with '+' sign) format
        /// </summary>
        public string phoneNumber;
    }
}