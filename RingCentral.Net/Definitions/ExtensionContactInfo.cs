namespace RingCentral
{
    public class ExtensionContactInfo
    {
        /* For User extension type only. Extension user first name */
        public string firstName;

        /* For User extension type only. Extension user last name */
        public string lastName;

        /* Extension user company name */
        public string company;

        /* Email of extension user */
        public string email;

        /* Extension user contact phone number */
        public string businessPhone;

        /* Business address of extension user company */
        public ContactAddressInfo businessAddress;
    }
}