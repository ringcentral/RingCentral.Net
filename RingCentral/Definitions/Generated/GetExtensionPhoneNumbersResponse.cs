namespace RingCentral
{
    public class GetExtensionPhoneNumbersResponse
    {
        // List of phone numbers
        public UserPhoneNumberInfo[] records; // Required

        // Information on navigation
        public ProvisioningNavigationInfo navigation; // Required

        // Information on paging
        public ProvisioningPagingInfo paging; // Required
    }
}