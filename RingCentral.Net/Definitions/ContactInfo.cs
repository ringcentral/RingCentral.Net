namespace RingCentral
{
    /// <summary>
    ///     Detailed contact information
    /// </summary>
    public class ContactInfo
    {
        /// <summary>
        ///     User's first name (for extensions of `User` type only)
        /// </summary>
        public string firstName { get; set; }

        /// <summary>
        ///     For User extension type only. User's last name (for extensions of `User` type only)
        /// </summary>
        public string lastName { get; set; }

        /// <summary>
        ///     Extension name (for extensions of `User` type - concatenation of first and last name)
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     User's company name
        /// </summary>
        public string company { get; set; }

        /// <summary>
        ///     User's job title
        /// </summary>
        public string jobTitle { get; set; }

        /// <summary>
        ///     User's contact email
        ///     Format: email
        /// </summary>
        public string email { get; set; }

        /// <summary>
        ///     User's contact phone number in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I)
        ///     (with '+' sign) format
        /// </summary>
        public string businessPhone { get; set; }

        /// <summary>
        ///     User's mobile (**non** Toll Free) phone number in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I)
        ///     (with '+' sign) format
        /// </summary>
        public string mobilePhone { get; set; }

        /// <summary>
        /// </summary>
        public ContactBusinessAddressInfo businessAddress { get; set; }

        /// <summary>
        ///     Indicates that the contact email is enabled as a login name for this
        ///     user. Please note that the email must be unique in this case.
        /// </summary>
        public bool? emailAsLoginName { get; set; }

        /// <summary>
        /// </summary>
        public PronouncedNameInfo pronouncedName { get; set; }

        /// <summary>
        ///     User's department name
        /// </summary>
        public string department { get; set; }
    }
}