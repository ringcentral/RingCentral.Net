namespace RingCentral
{
    public class ContactResource
    {
        /// <summary>
        /// </summary>
        public AccountResource account { get; set; }

        /// <summary>
        /// </summary>
        public string department { get; set; }

        /// <summary>
        /// </summary>
        public string email { get; set; }

        /// <summary>
        /// </summary>
        public string extensionNumber { get; set; }

        /// <summary>
        /// First name of a contact, for user extensions only
        /// </summary>
        public string firstName { get; set; }

        /// <summary>
        /// Last name of a contact, for user extensions only
        /// </summary>
        public string lastName { get; set; }

        /// <summary>
        /// Name of a contact, for non-user extensions
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// </summary>
        public string jobTitle { get; set; }

        /// <summary>
        /// </summary>
        public PhoneNumberResource[] phoneNumbers { get; set; }

        /// <summary>
        /// </summary>
        public AccountDirectoryProfileImageResource profileImage { get; set; }

        /// <summary>
        /// </summary>
        public BusinessSiteResource site { get; set; }

        /// <summary>
        /// </summary>
        public string status { get; set; }

        /// <summary>
        /// </summary>
        public string type { get; set; }
    }
}