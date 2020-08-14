namespace RingCentral
{
    public class ContactDirectoryEvent
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
        /// Extension Type
        /// </summary>
        public string type;

        /// <summary>
        /// Status of an extension
        /// Enum: Disabled, Enabled, NotActivated
        /// </summary>
        public string status;

        /// <summary>
        /// First name of an extension user
        /// </summary>
        public string firstName;

        /// <summary>
        /// Last name of an extension user
        /// </summary>
        public string lastName;

        /// <summary>
        /// Department Name
        /// </summary>
        public string department;

        /// <summary>
        /// Email of an extension user
        /// </summary>
        public string email;

        /// <summary>
        /// Extension number
        /// </summary>
        public string extensionNumber;

        /// <summary>
        /// Account data of an extension
        /// </summary>
        public CompanyDirectoryAccountInfo account;

        /// <summary>
        /// Extension phone number information
        /// </summary>
        public CompanyDirectoryPhoneNumberInfo phoneNumbers;

        /// <summary>
        /// Site Data
        /// </summary>
        public ContactDirectorySiteInfo site;

        /// <summary>
        /// Extension profile image information. Not returned if profile images are absent for an extension
        /// </summary>
        public CompanyDirectoryProfileImageInfo profileImage;

        /// <summary>
        /// Internal identifier of a subscription owner extension
        /// </summary>
        public string ownerId;
    }
}