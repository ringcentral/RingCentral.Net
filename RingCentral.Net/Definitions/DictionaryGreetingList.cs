namespace RingCentral
{
    public class DictionaryGreetingList
    {
        /// <summary>
        ///     Canonical URI of greetings list resource
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     List of greetings
        /// </summary>
        public DictionaryGreetingInfo[] records { get; set; }

        /// <summary>
        /// </summary>
        public PageNavigationModel navigation { get; set; }

        /// <summary>
        /// </summary>
        public EnumeratedPagingModel paging { get; set; }
    }
}