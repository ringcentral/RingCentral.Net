namespace RingCentral
{
    public class EmergencyAddressInfoRequest
    {
        // Name of a customer
        public string customerName;

        // Street address, line 1 - street address, P.O. box, company name, c/o
        public string street;

        // Street address, line 2 - apartment, suite, unit, building, floor, etc
        public string street2;

        // City name
        public string city;

        // Zip code
        public string zip;

        // State/province name
        public string state;

        // Country name
        public string country;
    }
}