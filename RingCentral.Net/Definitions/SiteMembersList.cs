namespace RingCentral
{
    public class SiteMembersList
    {
        /// <summary>
        ///     Link to a site members list resource
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// </summary>
        public SiteMemberInfo[] records { get; set; }

        /// <summary>
        /// </summary>
        public PageNavigationModel navigation { get; set; }

        /// <summary>
        /// </summary>
        public EnumeratedPagingModel paging { get; set; }
    }
}