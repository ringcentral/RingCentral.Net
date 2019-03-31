namespace RingCentral
{
    public class PhoneNumberInfoNumberParser
    {
        /* Area code of location. The portion of the [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) number that identifies a specific geographic region/numbering area of the national numbering plan (NANP); that can be summarized as `NPA-NXX-xxxx` and covers Canada, the United States, parts of the Caribbean Sea, and some Atlantic and Pacific islands. See [North American Numbering Plan] (https://en.wikipedia.org/wiki/North_American_Numbering_Plan) for details */
        public string areaCode;

        /* Information on a country the phone number belongs to */
        public GetCountryInfoNumberParser[] country;

        /* Dialing format of a phone number */
        public string dialable;

        /* Phone number [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) format */
        public string e164;

        /* International format of a phone number */
        public string formattedInternational;

        /* Domestic format of a phone number */
        public string formattedNational;

        /* One of the numbers to be parsed, passed as a string in response */
        public string originalString;

        /* 'True' if the number is in a special format (for example N11 code) */
        public bool? special;

        /* Phone number [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) format without plus sign ('+') */
        public string normalized;

        /* Specifies if a phone number is toll free or not */
        public bool? tollFree;

        /* Sub-Address. The portion of the number that identifies a subscriber into the subscriber internal (non-public) network. */
        public string subAddress;

        /* Subscriber number. The portion of the [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) number that identifies a subscriber in a network or numbering area. */
        public string subscriberNumber;

        /* DTMF (Dual Tone Multi-Frequency) postfix */
        public string dtmfPostfix;
    }
}