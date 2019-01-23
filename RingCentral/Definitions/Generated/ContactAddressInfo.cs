namespace RingCentral
{
    public class ContactAddressInfo : Serializable
    {
        // Country name of extension user company. Not returned for Address Book
        public string country;
        // State/province name of extension user company
        public string state;
        // City name of extension user company
        public string city;
        // Street address of extension user company
        public string street;
        // Zip code of extension user company
        public string zip;
    }
}