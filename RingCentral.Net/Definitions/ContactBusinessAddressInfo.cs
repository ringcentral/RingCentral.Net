namespace RingCentral
{
    public class ContactBusinessAddressInfo
    {
        /// <summary>
        /// Country name of an extension user company
        /// </summary>
        public string country;

        /// <summary>
        /// State/province name of an extension user company. Mandatory for the USA, UK and Canada
        /// </summary>
        public string state;

        /// <summary>
        /// City name of an extension user company
        /// </summary>
        public string city;

        /// <summary>
        /// Street address of an extension user company
        /// </summary>
        public string street;

        /// <summary>
        /// Zip code of an extension user company
        /// </summary>
        public string zip;
    }
}