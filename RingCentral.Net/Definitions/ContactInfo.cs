namespace RingCentral
{
    // Contact detailed information
    public class ContactInfo
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
        /// </summary>
        public string jobTitle;

        /// <summary>
        /// Email of extension user
        /// </summary>
        public string email;

        /// <summary>
        /// Extension user contact phone number in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) (with '+' sign) format
        /// </summary>
        public string businessPhone;

        /// <summary>
        /// Extension user mobile (**non** Toll Free) phone number in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) (with '+' sign) format
        /// </summary>
        public string mobilePhone;

        /// <summary>
        /// </summary>
        public ContactBusinessAddressInfo businessAddress;

        /// <summary>
        /// If 'True' then contact email is enabled as login name for this user. Please note that email should be unique in this case.
        /// </summary>
        public bool? emailAsLoginName;

        /// <summary>
        /// </summary>
        public PronouncedNameInfo pronouncedName;

        /// <summary>
        /// Extension user department, if any
        /// </summary>
        public string department;
    }
}