namespace RingCentral
{
    public class IVRPrompts
    {
        /// <summary>
        /// Link to prompts library resource
        /// </summary>
        public string uri;

        /// <summary>
        /// List of Prompts
        /// </summary>
        public PromptInfo[] records;

        /// <summary>
        /// Information on navigation
        /// </summary>
        public CallHandlingNavigationInfo navigation;

        /// <summary>
        /// Information on paging
        /// </summary>
        public CallHandlingPagingInfo paging;
    }
}