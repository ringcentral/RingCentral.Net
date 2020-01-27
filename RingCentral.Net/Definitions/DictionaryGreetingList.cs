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
        /// Information on navigation
        /// </summary>
        public CallHandlingNavigationInfo navigation;

        /// <summary>
        /// Information on paging
        /// </summary>
        public CallHandlingPagingInfo paging;
    }
}