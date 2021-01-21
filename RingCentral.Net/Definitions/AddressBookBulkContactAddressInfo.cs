namespace RingCentral
{
    // Contact address information
    public class AddressBookBulkContactAddressInfo
    {
        /// <summary>
        /// Country name of extension user company. Not returned for Address Book
        /// </summary>
        public string country { get; set; }

        /// <summary>
        /// State/province name of extension user company
        /// </summary>
        public string state { get; set; }

        /// <summary>
        /// City name of extension user company
        /// </summary>
        public string city { get; set; }

        /// <summary>
        /// Street address of extension user company
        /// </summary>
        public string street { get; set; }

        /// <summary>
        /// Zip code of extension user company
        /// </summary>
        public string zip { get; set; }
    }
}