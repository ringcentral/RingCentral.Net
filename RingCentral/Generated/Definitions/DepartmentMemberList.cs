using Newtonsoft.Json;

namespace RingCentral
{
    public class DepartmentMemberList : Serializable
    {
        // List of department members extensions
        public ExtensionInfo[] records;
        // Information on navigation
        public NavigationInfo navigation;
        // Information on paging
        public PagingInfo paging;
    }
}