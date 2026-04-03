namespace RingCentral
{
    public class AccountLanguageInfoRequest
    {
        /// <summary>
        ///     Internal identifier of a language set as regional
        ///     Required
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Localization code of a language set as regional
        ///     Required
        /// </summary>
        public string localeCode { get; set; }
    }
}