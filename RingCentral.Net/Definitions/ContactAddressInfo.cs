namespace RingCentral
{
    public class ContactAddressInfo
    {
        /// <summary>
        /// Street address
        /// Example: 20 Davis Dr.
        /// </summary>
        public string street { get; set; }

        /// <summary>
        /// City name
        /// Example: Belmont
        /// </summary>
        public string city { get; set; }

        /// <summary>
        /// Country name
        /// </summary>
        public string country { get; set; }

        /// <summary>
        /// State/province name
        /// Example: CA
        /// </summary>
        public string state { get; set; }

        /// <summary>
        /// Zip/Postal code
        /// Example: 94002
        /// </summary>
        public string zip { get; set; }
    }
}