namespace RingCentral
{
    public class NetworksList
    {
        /// <summary>
        ///     Link to a networks resource
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// </summary>
        public NetworkInfo[] records { get; set; }

        /// <summary>
        /// </summary>
        public PageNavigationModel navigation { get; set; }

        /// <summary>
        /// </summary>
        public EnumeratedPagingModel paging { get; set; }
    }
}