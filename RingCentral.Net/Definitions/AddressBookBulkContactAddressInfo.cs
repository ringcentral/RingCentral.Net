namespace RingCentral
{
    public class AddressBookBulkContactAddressInfo
    {
        /// <summary>
        ///     Country name of the extension user company. Not returned for Address
        ///     Book
        /// </summary>
        public string country { get; set; }

        /// <summary>
        ///     State/province name of the extension user company
        /// </summary>
        public string state { get; set; }

        /// <summary>
        ///     City name of the extension user company
        /// </summary>
        public string city { get; set; }

        /// <summary>
        ///     Street address of the extension user company
        /// </summary>
        public string street { get; set; }

        /// <summary>
        ///     Zip code of the extension user company
        /// </summary>
        public string zip { get; set; }
    }
}