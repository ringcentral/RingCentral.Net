namespace RingCentral
{
    public class GetLocationListResponse
    {
        /* List of locations */
        public LocationInfo[] records;

        /* Information on navigation */
        public ProvisioningNavigationInfo navigation; // Required

        /* Information on paging */
        public ProvisioningPagingInfo paging; // Required
    }
}