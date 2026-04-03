namespace RingCentral
{
    public class LanguageList
    {
        /// <summary>
        ///     Canonical URI of the language list resource
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Language data
        /// </summary>
        public LanguageInfo[] records { get; set; }

        /// <summary>
        /// </summary>
        public PageNavigationModel navigation { get; set; }

        /// <summary>
        /// </summary>
        public EnumeratedPagingModel paging { get; set; }
    }
}