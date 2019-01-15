using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class UserTemplates : Serializable
    {
        // Link to user templates resource
        public string uri;
        // List of user templates
        public TemplateInfo[] records; // Required
        // Information on navigation
        public NavigationInfo navigation; // Required
        // Information on paging
        public PagingInfo paging; // Required
    }
}