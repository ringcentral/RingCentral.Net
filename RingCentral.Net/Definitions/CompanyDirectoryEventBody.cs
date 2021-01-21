namespace RingCentral
{
    // Notification payload body
    public class CompanyDirectoryEventBody
    {
        /// <summary>
        /// Internal identifier of an extension
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Type of change
        /// </summary>
        public string eventType { get; set; }

        /// <summary>
        /// Type of extension
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// Status of an extension
        /// Enum: Enabled, NotActivated, Disabled
        /// </summary>
        public string status { get; set; }

        /// <summary>
        /// First name of a user extension
        /// </summary>
        public string firstName { get; set; }

        /// <summary>
        /// Last name of a user extension
        /// </summary>
        public string lastName { get; set; }

        /// <summary>
        /// Name of a contact, for non-user extensions
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Department name
        /// </summary>
        public string department { get; set; }

        /// <summary>
        /// </summary>
        public string email { get; set; }

        /// <summary>
        /// </summary>
        public string extensionNumber { get; set; }

        /// <summary>
        /// </summary>
        public CompanyDirectoryAccountInfo account { get; set; }

        /// <summary>
        /// </summary>
        public CompanyDirectoryPhoneNumberInfo[] phoneNumbers { get; set; }

        /// <summary>
        /// </summary>
        public ContactDirectorySiteInfo site { get; set; }

        /// <summary>
        /// </summary>
        public CompanyDirectoryProfileImageInfo profileImage { get; set; }
    }
}