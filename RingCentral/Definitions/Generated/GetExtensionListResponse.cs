namespace RingCentral
{
    public class GetExtensionListResponse
    {
        // List of extensions with extension information
        public GetExtensionInfoResponse[] records; // Required

        // Information on navigation
        public NavigationInfo navigation; // Required

        // Information on paging
        public PagingInfo paging; // Required
    }
}