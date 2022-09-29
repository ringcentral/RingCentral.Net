namespace RingCentral
{
    public class PhoneNumberInfoNumberParser
    {
        /// <summary>
        ///     Original phone number string as it was passed in the request
        ///     Example: (650) 722-1621
        /// </summary>
        public string originalString { get; set; }

        /// <summary>
        /// </summary>
        public GetCountryInfoNumberParser country { get; set; }

        /// <summary>
        ///     Area code of location. The portion of the [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I)
        ///     number that identifies a specific geographic region/numbering area of
        ///     the national numbering plan (NANP); that can be summarized as `NPA-NXX-xxxx`
        ///     and covers Canada, the United States, parts of the Caribbean Sea, and
        ///     some Atlantic and Pacific islands.
        ///     See [North American Numbering Plan](https://en.wikipedia.org/wiki/North_American_Numbering_Plan)
        ///     for details
        ///     Example: 650
        /// </summary>
        public string areaCode { get; set; }

        /// <summary>
        ///     Dialing format of a phone number
        /// </summary>
        public string dialable { get; set; }

        /// <summary>
        ///     Phone number in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) format
        /// </summary>
        public string e164 { get; set; }

        /// <summary>
        ///     The formatted phone number string in international format
        /// </summary>
        public string formattedInternational { get; set; }

        /// <summary>
        ///     The formatted phone number string in domestic format
        /// </summary>
        public string formattedNational { get; set; }

        /// <summary>
        ///     Indicates if the number is in a special format (for example N11 code)'
        /// </summary>
        public bool? special { get; set; }

        /// <summary>
        ///     Phone number in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) format without plus sign ('+')
        /// </summary>
        public string normalized { get; set; }

        /// <summary>
        ///     Indicates if the number is toll free
        /// </summary>
        public bool? tollFree { get; set; }

        /// <summary>
        ///     Sub-Address. The portion of the number that identifies a subscriber into the subscriber internal (non-public)
        ///     network.
        /// </summary>
        public string subAddress { get; set; }

        /// <summary>
        ///     Subscriber number. The portion of the [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) number that identifies
        ///     a subscriber in a network or numbering area.
        /// </summary>
        public string subscriberNumber { get; set; }

        /// <summary>
        ///     DTMF (Dual Tone Multi-Frequency) postfix
        /// </summary>
        public string dtmfPostfix { get; set; }
    }
}