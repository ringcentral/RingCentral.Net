namespace RingCentral
{
    public class ParsePhoneNumberResponse
    {
        /// <summary>
        /// Canonical URI of a resource
        /// </summary>
        public string uri;

        /// <summary>
        /// Required
        /// </summary>
        public GetCountryInfoNumberParser homeCountry;

        /// <summary>
        /// Parsed phone numbers data
        /// Required
        /// </summary>
        public PhoneNumberInfoNumberParser[] phoneNumbers;
    }
}