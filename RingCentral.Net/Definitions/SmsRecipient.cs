namespace RingCentral
{
    public class SmsRecipient
    {
        /// <summary>
        ///     ID of extension who is configured as a CQ's SMS recipient.
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     PIN of the extension who is configured as a CQ's SMS recipient.
        /// </summary>
        public string extensionNumber { get; set; }

        /// <summary>
        ///     Type of the extension assigned as Sms recipient.
        ///     Example: User
        ///     Enum: User, DigitalUser, ApplicationExtension
        /// </summary>
        public string extensionType { get; set; }

        /// <summary>
        ///     Name (first + last) of the extension who is configured as a CQ's SMS recipient.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Indicates user's ability to become a thread assignee.
        /// </summary>
        public bool? assignable { get; set; }

        /// <summary>
        ///     Indicates availability of a new MessageThreadsPaid feature status.
        /// </summary>
        public bool? hasLicense { get; set; }
    }
}