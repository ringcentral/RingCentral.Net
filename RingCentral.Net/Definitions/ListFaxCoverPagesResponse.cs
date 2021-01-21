namespace RingCentral
{
    public class ListFaxCoverPagesResponse
    {
        /// <summary>
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// </summary>
        public FaxCoverPageInfo[] records { get; set; }

        /// <summary>
        /// </summary>
        public MessagingNavigationInfo navigation { get; set; }

        /// <summary>
        /// </summary>
        public MessagingPagingInfo paging { get; set; }
    }
}