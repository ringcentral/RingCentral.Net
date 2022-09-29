namespace RingCentral
{
    public class ParsePhoneNumberResponse
    {
        /// <summary>
        ///     Canonical URI of a resource
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public GetCountryInfoNumberParser homeCountry { get; set; }

        /// <summary>
        ///     Parsed phone numbers information
        ///     Required
        /// </summary>
        public PhoneNumberInfoNumberParser[] phoneNumbers { get; set; }
    }
}