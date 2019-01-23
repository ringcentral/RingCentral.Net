namespace RingCentral
{
    public class PhoneNumberInfoNumberParser : Serializable
    {
        // Area code of the location (3-digit usually), according to the NANP number format, that can be summarized as NPA-NXX-xxxx and covers Canada, the United States, parts of the Caribbean Sea, and some Atlantic and Pacific islands. See North American Numbering Plan for details
        public string areaCode;
        // Information on a country the phone number belongs to
        public GetCountryInfoNumberParser[] country;
        // Dialing format of a phone number
        public string dialable;
        // E.164 (11-digits) format of a phone number
        public string e164;
        // International format of a phone number
        public string formattedInternational;
        // Domestic format of a phone number
        public string formattedNational;
        // One of the numbers to be parsed, passed as a string in response
        public string originalString;
        // 'True'  if the number is in a special format (for example N11 code)
        public bool? special;
        // E.164 (11-digits) format of a phone number without the plus sign ('+')
        public string normalized;
        // Specifies if a phone number is toll free or not
        public bool? tollFree;
        // Address of a subscriber
        public string subAddress;
        // Phone number of a subscriber
        public string subscriberNumber;
        // DTMF (Dual Tone Multi-Frequency) postfix
        public string dtmfPostfix;
    }
}