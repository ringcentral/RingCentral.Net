namespace RingCentral
{
    public class ListFaxCoverPagesResponse
    {
        /// <summary>
        /// </summary>
        public string uri;

        /// <summary>
        /// </summary>
        public FaxCoverPageInfo[] records;

        /// <summary>
        /// Information on navigation
        /// </summary>
        public MessagingNavigationInfo navigation;

        /// <summary>
        /// Information on paging
        /// </summary>
        public MessagingPagingInfo paging;
    }
}