namespace RingCentral
{
    public class AutomaticLocationUpdatesUserList
    {
        /// <summary>
        ///     Link to the users list resource
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// </summary>
        public AutomaticLocationUpdatesUserInfo[] records { get; set; }

        /// <summary>
        /// </summary>
        public PageNavigationModel navigation { get; set; }

        /// <summary>
        /// </summary>
        public EnumeratedPagingModel paging { get; set; }
    }
}