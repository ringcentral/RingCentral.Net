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
        public NavigationInfo navigation { get; set; }

        /// <summary>
        /// </summary>
        public EnumeratedPaging paging { get; set; }
    }
}