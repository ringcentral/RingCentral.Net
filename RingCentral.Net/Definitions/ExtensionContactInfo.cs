namespace RingCentral
{
    public class ExtensionContactInfo
    {
        /// <summary>
        /// For User extension type only. Extension user first name
        /// </summary>
        public string firstName { get; set; }

        /// <summary>
        /// For User extension type only. Extension user last name
        /// </summary>
        public string lastName { get; set; }

        /// <summary>
        /// Extension user company name
        /// </summary>
        public string company { get; set; }

        /// <summary>
        /// Email of extension user
        /// </summary>
        public string email { get; set; }

        /// <summary>
        /// Extension user contact phone number
        /// </summary>
        public string businessPhone { get; set; }

        /// <summary>
        /// </summary>
        public ContactAddressInfoDevices businessAddress { get; set; }
    }
}