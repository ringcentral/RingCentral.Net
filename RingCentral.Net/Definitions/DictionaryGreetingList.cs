namespace RingCentral
{
    public class DictionaryGreetingList
    {
        /// <summary>
        ///     Canonical URI of greetings list resource
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     List of greetings
        /// </summary>
        public DictionaryGreetingInfo[] records { get; set; }

        /// <summary>
        /// </summary>
        public CallHandlingNavigationInfo navigation { get; set; }

        /// <summary>
        /// </summary>
        public CallHandlingPagingInfo paging { get; set; }
    }
}