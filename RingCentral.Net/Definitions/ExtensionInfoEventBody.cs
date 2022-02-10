namespace RingCentral
{
    /// <summary>
    ///     Notification payload body
    /// </summary>
    public class ExtensionInfoEventBody
    {
        /// <summary>
        ///     Internal identifier of an extension
        /// </summary>
        public string extensionId { get; set; }

        /// <summary>
        ///     Type of extension info change
        ///     Enum: Update, Delete
        /// </summary>
        public string eventType { get; set; }

        /// <summary>
        ///     Returned for 'Update' event type only
        ///     Enum: AccountSettings, AccountStatus, AnsweringRules, CompanyNumbers, DialingPlan, ExtensionInfo, Features, Limits,
        ///     Permissions, ProfileImage, VideoConfiguration
        /// </summary>
        public string[] hints { get; set; }

        /// <summary>
        ///     Internal identifier of a subscription owner extension
        /// </summary>
        public string ownerId { get; set; }
    }
}