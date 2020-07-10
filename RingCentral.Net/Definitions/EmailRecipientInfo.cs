namespace RingCentral
{
    public class EmailRecipientInfo
    {
        /// <summary>
        /// Internal identifier of an extension
        /// </summary>
        public string extensionId;

        /// <summary>
        /// User full name
        /// </summary>
        public string fullName;

        /// <summary>
        /// User extension number
        /// </summary>
        public string extensionNumber;

        /// <summary>
        /// Current state of an extension
        /// Enum: Enabled, Disable, NotActivated, Unassigned
        /// </summary>
        public string status;

        /// <summary>
        /// List of user email addresses from extension notification settings. By default main email address from contact information is returned
        /// </summary>
        public string[] emailAddresses;

        /// <summary>
        /// Call queue manager permission
        /// Enum: FullAccess, MembersOnly
        /// </summary>
        public string permission;
    }
}