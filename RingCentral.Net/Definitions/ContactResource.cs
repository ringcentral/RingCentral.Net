namespace RingCentral
{
    public class ContactResource
    {
        /// <summary>
        /// </summary>
        public AccountResource account;

        /// <summary>
        /// </summary>
        public string department;

        /// <summary>
        /// </summary>
        public string email;

        /// <summary>
        /// </summary>
        public string extensionNumber;

        /// <summary>
        /// First name of a contact, for user extensions only
        /// </summary>
        public string firstName;

        /// <summary>
        /// Last name of a contact, for user extensions only
        /// </summary>
        public string lastName;

        /// <summary>
        /// Name of a contact, for non-user extensions
        /// </summary>
        public string name;

        /// <summary>
        /// </summary>
        public string id;

        /// <summary>
        /// </summary>
        public string jobTitle;

        /// <summary>
        /// </summary>
        public PhoneNumberResource[] phoneNumbers;

        /// <summary>
        /// </summary>
        public AccountDirectoryProfileImageResource profileImage;

        /// <summary>
        /// </summary>
        public BusinessSiteResource site;

        /// <summary>
        /// </summary>
        public string status;

        /// <summary>
        /// </summary>
        public string type;
    }
}