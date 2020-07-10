namespace RingCentral
{
    public class UserAnsweringRuleListRecord
    {
        /// <summary>
        /// Canonical URI to an answering rule resource
        /// </summary>
        public string uri;

        /// <summary>
        /// Internal identifier of an asnwering rule
        /// </summary>
        public string id;

        /// <summary>
        /// Type of an answering rule
        /// Enum: BusinessHours, AfterHours, Custom
        /// </summary>
        public string type;

        /// <summary>
        /// Name of an answering rule specified by user
        /// </summary>
        public string name;

        /// <summary>
        /// Specifies if an answering rule is active or inactive
        /// </summary>
        public bool? enabled;

        /// <summary>
        /// SharedLines call handling action settings
        /// </summary>
        public SharedLinesInfo sharedLines;
    }
}