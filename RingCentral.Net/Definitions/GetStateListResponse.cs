namespace RingCentral
{
    public class GetStateListResponse
    {
        /* List of states */
        public GetStateInfoResponse[] records; // Required

        /* Information on navigation */
        public ProvisioningNavigationInfo navigation; // Required

        /* Information on paging */
        public ProvisioningPagingInfo paging; // Required
    }
}