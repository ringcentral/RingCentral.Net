namespace RingCentral
{
    public class GetCountryInfoDictionaryResponse
    {
        /* Internal identifier of a country */
        public string id;

        /* Canonical URI of a country */
        public string uri;

        /* Country calling code defined by ITU-T recommendations [E.123](https://www.itu.int/rec/T-REC-E.123-200102-I/en) and [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) */
        public string callingCode;

        /* Emergency calling feature availability/emergency address requirement indicator */
        public bool? emergencyCalling;

        /* Country code according to the ISO standard, see [ISO 3166](https://www.iso.org/iso-3166-country-codes.html) */
        public string isoCode;

        /* Official name of a country */
        public string name;

        /* Determines whether phone numbers are available for a country */
        public bool? numberSelling;

        /* Specifies whether login with the phone numbers of this country is enabled or not */
        public bool? loginAllowed;

        /* Indicates whether signup/billing is allowed for a country */
        public bool? signupAllowed;

        /* Specifies if free phone line for softphone is available for a country or not */
        public bool? freeSoftphoneLine;
    }
}