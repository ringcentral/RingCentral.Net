namespace RingCentral
{
    public class ListFaxCoverPagesResponse
    {
        public string uri;

        public FaxCoverPageInfo[] records;

        /* Information on navigation */
        public MessagingNavigationInfo navigation;

        /* Information on paging */
        public MessagingPagingInfo paging;
    }
}