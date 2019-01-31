namespace RingCentral
{
    public class ListFaxCoverPagesResponse
    {
        public string uri;

        public FaxCoverPageInfo[] records;

        // Information on navigation
        public NavigationInfo navigation;

        // Information on paging
        public PagingInfo paging;
    }
}