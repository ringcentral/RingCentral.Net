namespace RingCentral
{
    public class ExtensionContactInfo
    {
        /// <summary>
        /// For User extension type only. Extension user first name
        /// </summary>
        public string firstName;

        /// <summary>
        /// For User extension type only. Extension user last name
        /// </summary>
        public string lastName;

        /// <summary>
        /// Extension user company name
        /// </summary>
        public string company;

        /// <summary>
        /// Email of extension user
        /// </summary>
        public string email;

        /// <summary>
        /// Extension user contact phone number
        /// </summary>
        public string businessPhone;

        /// <summary>
        /// Business address of extension user company
        /// </summary>
        public ContactAddressInfo businessAddress;
    }
}