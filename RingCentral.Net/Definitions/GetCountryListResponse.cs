namespace RingCentral
{
    public class GetCountryListResponse
    {
        // List of countries with the country data
        public GetCountryInfoDictionaryResponse[] records; // Required

        // Information on navigation
        public ProvisioningNavigationInfo navigation; // Required

        // Information on paging
        public ProvisioningPagingInfo paging; // Required
    }
}