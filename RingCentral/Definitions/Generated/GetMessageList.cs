namespace RingCentral
{
    public class GetMessageList
    {
        // List of records with message information
        public GetMessageInfoResponse[] records; // Required

        // Information on navigation
        public NavigationInfo navigation; // Required

        // Information on paging
        public PagingInfo paging; // Required
    }
}