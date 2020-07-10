namespace RingCentral
{
    public class ExtensionInfoEventBody
    {
        /// <summary>
        /// Internal identifier of an extension
        /// </summary>
        public string extensionId;

        /// <summary>
        /// Type of extension info change
        /// Enum: Update, Delete
        /// </summary>
        public string eventType;

        /// <summary>
        /// Returned for 'Update' event type only
        /// Enum: AccountSettings, AccountStatus, AnsweringRules, CompanyNumbers, DialingPlan, ExtensionInfo, Features, Limits, Permissions, ProfileImage, VideoConfiguration
        /// </summary>
        public string[] hints;

        /// <summary>
        /// Internal identifier of a subscription owner extension
        /// </summary>
        public string ownerId;
    }
}