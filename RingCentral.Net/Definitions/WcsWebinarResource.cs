namespace RingCentral
{
    public class WcsWebinarResource
    {
        /// <summary>
        ///     Internal object ID
        ///     Example: 78654321
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Object creation time
        ///     Required
        ///     Format: date-time
        /// </summary>
        public string creationTime { get; set; }

        /// <summary>
        ///     Object last modification time
        ///     Required
        ///     Format: date-time
        /// </summary>
        public string lastModifiedTime { get; set; }

        /// <summary>
        ///     Webinar title
        ///     Example: All-Hands Webinar
        /// </summary>
        public string title { get; set; }

        /// <summary>
        ///     User-friendly description of the Webinar
        ///     Example: Quarterly All-hands event to present recent news about our company to employees
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// </summary>
        public WcsWebinarSettingsModel settings { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public WcsHostModel host { get; set; }
    }
}