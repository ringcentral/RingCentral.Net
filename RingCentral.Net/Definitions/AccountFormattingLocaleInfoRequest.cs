namespace RingCentral
{
    public class AccountFormattingLocaleInfoRequest
    {
        /// <summary>
        ///     Internal identifier of a formatting language
        ///     Required
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Localization code of a formatting language
        ///     Required
        /// </summary>
        public string localeCode { get; set; }
    }
}