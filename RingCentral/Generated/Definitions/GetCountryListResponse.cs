using Newtonsoft.Json;

namespace RingCentral
{
    public class GetCountryListResponse : Serializable
    {
        // List of countries with the country data
        public GetCountryInfoDictionaryResponse[] records;
        // Information on navigation
        public NavigationInfo navigation;
        // Information on paging
        public PagingInfo paging;
    }
}