using Newtonsoft.Json;

namespace RingCentral
{
    public class UserTemplates : Serializable
    {
        // Link to user templates resource
        public string uri;
        // List of user templates
        public TemplateInfo[] records;
        // Information on navigation
        public NavigationInfo navigation;
        // Information on paging
        public PagingInfo paging;
    }
}