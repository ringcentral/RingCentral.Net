namespace RingCentral
{
    public class GetTimezoneListResponse
    {
        // List of timezones
        public GetTimezoneInfoResponse[] records; // Required

        // Information on navigation
        public ProvisioningNavigationInfo navigation; // Required

        // Information on paging
        public ProvisioningPagingInfo paging; // Required
    }
}