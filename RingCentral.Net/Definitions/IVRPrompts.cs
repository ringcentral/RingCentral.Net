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
        /// </summary>
        public CallHandlingNavigationInfo navigation;

        /// <summary>
        /// </summary>
        public CallHandlingPagingInfo paging;
    }
}