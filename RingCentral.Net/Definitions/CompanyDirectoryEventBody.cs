namespace RingCentral
{
    public class CompanyDirectoryEventBody
    {
        /// <summary>
        /// Internal identifier of an extension
        /// </summary>
        public string id;

        /// <summary>
        /// Type of change
        /// </summary>
        public string eventType;

        /// <summary>
        /// Type of extension
        /// </summary>
        public string type;

        /// <summary>
        /// Status of an extension
        /// Enum: Enabled, NotActivated, Disabled
        /// </summary>
        public string status;

        /// <summary>
        /// First name of a user extension
        /// </summary>
        public string firstName;

        /// <summary>
        /// Last name of a user extension
        /// </summary>
        public string lastName;

        /// <summary>
        /// Name of a contact, for non-user extensions
        /// </summary>
        public string name;

        /// <summary>
        /// Department name
        /// </summary>
        public string department;

        /// <summary>
        /// </summary>
        public string email;

        /// <summary>
        /// </summary>
        public string extensionNumber;

        /// <summary>
        /// </summary>
        public CompanyDirectoryAccountInfo account;

        /// <summary>
        /// </summary>
        public CompanyDirectoryPhoneNumberInfo[] phoneNumbers;

        /// <summary>
        /// Site data
        /// </summary>
        public ContactDirectorySiteInfo site;

        /// <summary>
        /// Extension profile image information. Not returned if profile images are absent for an extension
        /// </summary>
        public CompanyDirectoryProfileImageInfo profileImage;
    }
}