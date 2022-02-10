namespace RingCentral
{
    /// <summary>
    ///     Formatting language preferences for numbers, dates and currencies
    /// </summary>
    public class FormattingLocaleInfo
    {
        /// <summary>
        ///     Internal identifier of a formatting language
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Localization code of a formatting language
        /// </summary>
        public string localeCode { get; set; }

        /// <summary>
        ///     Official name of a formatting language
        /// </summary>
        public string name { get; set; }
    }
}