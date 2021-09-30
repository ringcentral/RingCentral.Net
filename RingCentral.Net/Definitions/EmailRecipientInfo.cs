namespace RingCentral
{
    public class EmailRecipientInfo
    {
        /// <summary>
        ///     Internal identifier of an extension
        /// </summary>
        public string extensionId { get; set; }

        /// <summary>
        ///     User full name
        /// </summary>
        public string fullName { get; set; }

        /// <summary>
        ///     User extension number
        /// </summary>
        public string extensionNumber { get; set; }

        /// <summary>
        ///     Current state of an extension
        ///     Enum: Enabled, Disable, NotActivated, Unassigned
        /// </summary>
        public string status { get; set; }

        /// <summary>
        ///     List of user email addresses from extension notification settings. By default main email address from contact
        ///     information is returned
        /// </summary>
        public string[] emailAddresses { get; set; }

        /// <summary>
        ///     Call queue manager permission
        ///     Enum: FullAccess, Messages, MemberManagement
        /// </summary>
        public string permission { get; set; }
    }
}