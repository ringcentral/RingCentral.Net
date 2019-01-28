namespace RingCentral
{
    public class GetExtensionGrantListResponse
    {
        // List of extension grants with details
        public GrantInfo[] records; // Required

        // Information on navigation
        public NavigationInfo navigation; // Required

        // Information on paging
        public PagingInfo paging; // Required
    }
}