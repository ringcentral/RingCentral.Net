namespace RingCentral
{
    public class IVRPrompts : Serializable
    {
        // Link to prompts library resource
        public string uri;
        // List of Prompts
        public PromptInfo[] records;
        // Information on navigation
        public NavigationInfo navigation;
        // Information on paging
        public PagingInfo paging;
    }
}