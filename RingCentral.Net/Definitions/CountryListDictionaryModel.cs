namespace RingCentral
{
    public class CountryListDictionaryModel
    {
        /// <summary>
        ///     Link to the list of countries supported
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     List of countries with the country data
        ///     Required
        /// </summary>
        public CountryInfoDictionaryModel[] records { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public PageNavigationModel navigation { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public EnumeratedPagingModel paging { get; set; }
    }
}