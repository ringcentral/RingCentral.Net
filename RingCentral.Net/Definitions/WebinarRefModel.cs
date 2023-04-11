namespace RingCentral
{
    public class WebinarRefModel
    {
        /// <summary>
        ///     Internal object ID
        ///     Example: 78654321
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Webinar title
        ///     Required
        ///     Example: All-Hands Webinar
        /// </summary>
        public string title { get; set; }

        /// <summary>
        ///     User-friendly description of the Webinar
        ///     Example: Quarterly All-hands event to present recent news about our company to employees
        /// </summary>
        public string description { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public HostModel host { get; set; }
    }
}