namespace RingCentral
{
    public class GetExtensionGrantListResponse : Serializable
    {
        // List of extension grants with details
        public GrantInfo[] records; // Required
        // Information on navigation
        public NavigationInfo navigation; // Required
        // Information on paging
        public PagingInfo paging; // Required
    }
}