namespace RingCentral
{
    /// <summary>
    ///     User's business address. The default is
    ///     Company (Auto-Receptionist) settings
    /// </summary>
    public class ContactBusinessAddressInfo
    {
        /// <summary>
        ///     Country name of a user's company
        /// </summary>
        public string country { get; set; }

        /// <summary>
        ///     State/province name of a user's company. Mandatory
        ///     for the USA, UK and Canada
        /// </summary>
        public string state { get; set; }

        /// <summary>
        ///     City name of a user's company
        /// </summary>
        public string city { get; set; }

        /// <summary>
        ///     Street address of a user's company
        /// </summary>
        public string street { get; set; }

        /// <summary>
        ///     Zip code of a user's company
        /// </summary>
        public string zip { get; set; }
    }
}