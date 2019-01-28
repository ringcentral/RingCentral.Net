namespace RingCentral
{
    public class GetStateListResponse
    {
        // List of states
        public GetStateInfoResponse[] records; // Required

        // Information on navigation
        public NavigationInfo navigation; // Required

        // Information on paging
        public PagingInfo paging; // Required
    }
}