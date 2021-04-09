namespace RingCentral
{
    public class ContactDirectoryEvent
    {
        /// <summary>
        ///     Internal identifier of an extension
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Type of change
        /// </summary>
        public string eventType { get; set; }

        /// <summary>
        ///     Extension Type
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Status of an extension
        ///     Enum: Disabled, Enabled, NotActivated
        /// </summary>
        public string status { get; set; }

        /// <summary>
        ///     First name of an extension user
        /// </summary>
        public string firstName { get; set; }

        /// <summary>
        ///     Last name of an extension user
        /// </summary>
        public string lastName { get; set; }

        /// <summary>
        ///     Department Name
        /// </summary>
        public string department { get; set; }

        /// <summary>
        ///     Email of an extension user
        /// </summary>
        public string email { get; set; }

        /// <summary>
        ///     Extension number
        /// </summary>
        public string extensionNumber { get; set; }

        /// <summary>
        /// </summary>
        public CompanyDirectoryAccountInfo account { get; set; }

        /// <summary>
        /// </summary>
        public CompanyDirectoryPhoneNumberInfo phoneNumbers { get; set; }

        /// <summary>
        /// </summary>
        public ContactDirectorySiteInfo site { get; set; }

        /// <summary>
        /// </summary>
        public CompanyDirectoryProfileImageInfo profileImage { get; set; }

        /// <summary>
        ///     Internal identifier of a subscription owner extension
        /// </summary>
        public string ownerId { get; set; }
    }
}