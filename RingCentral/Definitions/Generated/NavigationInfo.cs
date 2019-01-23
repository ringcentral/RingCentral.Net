using Newtonsoft.Json;

namespace RingCentral
{
    public class NavigationInfo : Serializable
    {
        // Canonical URI for the first page of the list
        public NavigationInfoURI firstPage;
        // Canonical URI for the next page of the list
        public NavigationInfoURI nextPage;
        // Canonical URI for the previous page of the list
        public NavigationInfoURI previousPage;
        // Canonical URI for the last page of the list
        public NavigationInfoURI lastPage;
    }
}