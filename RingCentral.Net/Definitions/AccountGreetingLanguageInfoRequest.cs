namespace RingCentral
{
    public class AccountGreetingLanguageInfoRequest
    {
        /// <summary>
        ///     Internal identifier of a greeting language
        ///     Required
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Localization code of a greeting language
        ///     Required
        /// </summary>
        public string localeCode { get; set; }
    }
}