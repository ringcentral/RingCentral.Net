using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class GetCountryListResponse : Serializable
    {
        // List of countries with the country data
        public GetCountryInfoDictionaryResponse[] records; // Required
        // Information on navigation
        public NavigationInfo navigation; // Required
        // Information on paging
        public PagingInfo paging; // Required
    }
}