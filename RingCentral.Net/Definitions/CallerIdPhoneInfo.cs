namespace RingCentral
{
    public class CallerIdPhoneInfo
    {
        /// <summary>
        ///     Internal identifier of a phone number
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Link to a phone number resource
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Phone number in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I)
        ///     (with '+' sign) format
        /// </summary>
        public string phoneNumber { get; set; }
    }
}