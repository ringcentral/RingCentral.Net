namespace RingCentral
{
    public class ParsePhoneNumberResponse
    {
        /// <summary>
        ///     Canonical URI of a resource
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public GetCountryInfoNumberParser homeCountry { get; set; }

        /// <summary>
        ///     Parsed phone numbers data
        ///     Required
        /// </summary>
        public PhoneNumberInfoNumberParser[] phoneNumbers { get; set; }
    }
}