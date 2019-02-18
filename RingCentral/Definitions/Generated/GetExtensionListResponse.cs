namespace RingCentral
{
    public class GetExtensionListResponse
    {
        // List of extensions with extension information
        public GetExtensionInfoResponse[] records; // Required

        // Information on navigation
        public ProvisioningNavigationInfo navigation; // Required

        // Information on paging
        public ProvisioningPagingInfo paging; // Required
    }
}