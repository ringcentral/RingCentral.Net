namespace RingCentral
{
    public class ContactInfoUpdateRequest
    {
        /// <summary>
        ///     For User extension type only. Extension user first name
        /// </summary>
        public string firstName { get; set; }

        /// <summary>
        ///     For User extension type only. Extension user last name
        /// </summary>
        public string lastName { get; set; }

        /// <summary>
        ///     Extension user company name
        /// </summary>
        public string company { get; set; }

        /// <summary>
        /// </summary>
        public string jobTitle { get; set; }

        /// <summary>
        ///     Email of extension user
        ///     Format: email
        /// </summary>
        public string email { get; set; }

        /// <summary>
        ///     Extension user contact phone number in
        ///     [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I)
        ///     format
        /// </summary>
        public string businessPhone { get; set; }

        /// <summary>
        ///     Extension user mobile (**non** Toll Free) phone number in
        ///     [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I)
        ///     (with '+' sign) format
        /// </summary>
        public string mobilePhone { get; set; }

        /// <summary>
        /// </summary>
        public ContactBusinessAddressInfo businessAddress { get; set; }

        /// <summary>
        ///     If 'True' then contact email is enabled as login name for
        ///     this user. Please note that email should be unique in this case.
        ///     The default value is 'False'
        /// </summary>
        public bool? emailAsLoginName { get; set; }

        /// <summary>
        /// </summary>
        public PronouncedNameInfo pronouncedName { get; set; }

        /// <summary>
        ///     Extension user department, if any
        /// </summary>
        public string department { get; set; }
    }
}