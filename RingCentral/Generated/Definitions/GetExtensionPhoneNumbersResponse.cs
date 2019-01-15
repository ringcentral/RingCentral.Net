using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class GetExtensionPhoneNumbersResponse : Serializable
    {
        // List of phone numbers
        public UserPhoneNumberInfo[] records;
        // Information on navigation
        public NavigationInfo navigation;
        // Information on paging
        public PagingInfo paging;
    }
}