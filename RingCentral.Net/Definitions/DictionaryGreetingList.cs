namespace RingCentral
{
    public class DictionaryGreetingList
    {
        /// <summary>
        /// Canonical URI of greetings list resource
        /// </summary>
        public string uri;

        /// <summary>
        /// List of greetings
        /// </summary>
        public DictionaryGreetingInfo[] records;

        /// <summary>
        /// </summary>
        public CallHandlingNavigationInfo navigation;

        /// <summary>
        /// </summary>
        public CallHandlingPagingInfo paging;
    }
}