namespace RingCentral
{
    // Information on language used for telephony greetings
    public class GreetingLanguageInfo
    {
        /// <summary>
        ///     Internal identifier of a greeting language
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Localization code of a greeting language
        /// </summary>
        public string localeCode { get; set; }

        /// <summary>
        ///     Official name of a greeting language
        /// </summary>
        public string name { get; set; }
    }
}