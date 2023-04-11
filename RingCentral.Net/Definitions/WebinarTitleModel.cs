namespace RingCentral
{
    public class WebinarTitleModel
    {
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
    }
}